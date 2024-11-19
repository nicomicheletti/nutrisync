using CapaEntidad;
using CapaNegocio;
using CapaPresentacion.Modales;
using CapaPresentacion.Utilidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace CapaPresentacion
{
    public partial class frmVentas : Form
    {
        private Usuario _Usuario;


        public frmVentas(Usuario oUsuario = null)
        {
            _Usuario = oUsuario;
            InitializeComponent();
        }

        private void frmVentas_Load(object sender, EventArgs e)
        {
            cbotipodocumento.Items.Add(new OpcionCombo() { Valor = "Boleta", Texto = "Boleta" });
            cbotipodocumento.Items.Add(new OpcionCombo() { Valor = "Factura", Texto = "Factura" });

            cbotipodocumento.DisplayMember = "Texto";
            cbotipodocumento.ValueMember = "Valor";
            cbotipodocumento.SelectedIndex = 0;

            cbimpuesto.Items.Add(new OpcionCombo() { Valor = "ImpuestoSinDescuento", Texto = "Final" });
            cbimpuesto.Items.Add(new OpcionCombo() { Valor = "Reducido", Texto = "Membresia" });
            cbimpuesto.Items.Add(new OpcionCombo() { Valor = "Estandar", Texto = "Comercial" });
            cbimpuesto.Items.Add(new OpcionCombo() { Valor = "Superior", Texto = "Efectivo" });

            cbimpuesto.DisplayMember = "Texto";
            cbimpuesto.ValueMember = "Valor";
            cbimpuesto.SelectedIndex = 0;

            txtfecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
            txtidproducto.Text = "0";

            txtprecio.ReadOnly = true;
            txttotalpagar.Text = "0";
            txtcambio.Text = " ";
            txtpagacon.Text = " ";

            txtcantidad.Maximum = 50000;
        }

        public interface Impuesto
        {
            decimal CalcularImpuesto(decimal total);
        }

        public class ImpuestoEstandar : Impuesto
        {
            public decimal CalcularImpuesto(decimal total)
            {
                return total * 0.90m;
            }
        }

        public class ImpuestoReducido : Impuesto
        {
            public decimal CalcularImpuesto(decimal total)
            {
                return total * 0.70m;
            }
        }

        public class ImpuestoSuperior : Impuesto
        {
            public decimal CalcularImpuesto(decimal total)
            {
                return total * 0.79m;
            }
        }
        public class ImpuestoSinDescuento : Impuesto
        {
            public decimal CalcularImpuesto(decimal total)
            {
                return total; 
            }
        }


        private Impuesto _impuesto;

        public void EstablecerImpuestos(Impuesto strategy)
        {
            _impuesto = strategy;
        }

        private void btnbuscarcli_Click(object sender, EventArgs e)
        {
            using (var modal = new MD_Cliente())
            {
                var result = modal.ShowDialog();

                if (result == DialogResult.OK)
                {
                    txtdoccliente.Text = modal._Cliente.Documento;
                    txtnombrecliente.Text = modal._Cliente.NombreCompleto;
                    txtcodigoproducto.Select();
                }
                else
                {
                    txtdoccliente.Select();
                }
            }
        }

        private void btnbuscarproducto_Click(object sender, EventArgs e)
        {
            using (var modal = new MD_Producto())
            {
                var result = modal.ShowDialog();

                if (result == DialogResult.OK)
                {
                    txtidproducto.Text = modal._Producto.IdProducto.ToString();
                    txtcodigoproducto.Text = modal._Producto.Codigo;
                    txtproducto.Text = modal._Producto.Nombre;
                    txtprecio.Text = modal._Producto.PrecioVenta.ToString("0.00");
                    txtstock.Text = modal._Producto.Stock.ToString();
                    txtcantidad.Select();
                }
                else
                {
                    txtcodigoproducto.Select();
                }
            }
        }

        private void txtcodigoproducto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                Producto oProducto = new CN_Producto().Listar().Where(p => p.Codigo == txtcodigoproducto.Text && p.Estado == true).FirstOrDefault();
                if (oProducto != null)
                {
                    txtcodigoproducto.BackColor = Color.Honeydew;
                    txtidproducto.Text = oProducto.IdProducto.ToString();
                    txtproducto.Text = oProducto.Nombre;
                    txtprecio.Text = oProducto.PrecioVenta.ToString("0.00");
                    txtstock.Text = oProducto.Stock.ToString();
                    txtcantidad.Select();
                }
                else
                {
                    txtcodigoproducto.BackColor = Color.MistyRose;
                    txtidproducto.Text = "0";
                    txtproducto.Text = "";
                    txtprecio.Text = "";
                    txtstock.Text = "";
                    txtcantidad.Value = 1;
                }
            }
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            decimal precio = 0;
            bool producto_existe = false;

            if (int.Parse(txtidproducto.Text) == 0)
            {
                MessageBox.Show("Debe de seleccionar un producto\n", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (!decimal.TryParse(txtprecio.Text, out precio))
            {
                MessageBox.Show("Precio Compra - Formato moneda incorrecto\n", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtprecio.Select();
                return;
            }

            if (Convert.ToInt32(txtstock.Text) < Convert.ToInt32(txtcantidad.Value.ToString()) || Convert.ToInt32(txtcantidad.Value.ToString()) <= 0)
            {
                MessageBox.Show("La cantidad no puede ser mayor que el stock\n", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtcantidad.Select();
                return;
            }

            foreach (DataGridViewRow fila in dgvproducto.Rows)
            {
                if (fila.Cells["IdProducto"].Value.ToString() == txtidproducto.Text)
                {
                    producto_existe = true;
                    break;
                }

            }

            if (!producto_existe)
            {
                string mensaje = string.Empty;
                bool respuesta = new CN_Venta().RestarStock(
                    Convert.ToInt32(txtidproducto.Text),
                    Convert.ToInt32(txtcantidad.Value.ToString())
                    );

                if (respuesta)
                {
                    dgvproducto.Rows.Add(new object[]
                    {
                        txtidproducto.Text,
                        txtproducto.Text,
                        precio.ToString("0.00"),
                        txtcantidad.Value.ToString(),
                        _impuesto.CalcularImpuesto(txtcantidad.Value * precio).ToString("0.00")
                    });
                    limpiarProducto();
                    calcularTotal();
                    txtcodigoproducto.Select();
                }
            }
        }

        private void limpiarProducto()
        {
            txtidproducto.Text = "0";
            txtcodigoproducto.Text = "";
            txtcodigoproducto.BackColor = Color.White;
            txtproducto.Text = "";
            txtprecio.Text = "";
            txtstock.Text = "";
            txtcantidad.Value = 1;
        }

        private void calcularTotal()
        {
            decimal total = 0;
            if (dgvproducto.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvproducto.Rows)
                {
                    if (row.Cells["SubTotal"] != null && row.Cells["SubTotal"].Value != null)
                    {
                        total += Convert.ToDecimal(row.Cells["SubTotal"].Value.ToString());
                    }
                }
                txttotalpagar.Text = total.ToString("0.00");
            }
            else
            {
                txttotalpagar.Text = "0";
            }
        }

        private void dgvproducto_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (e.ColumnIndex == 5)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var w = Properties.Resources.check20.Width;
                var h = Properties.Resources.check20.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.delete25, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
        }

        private void dgvproducto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvproducto.Columns[e.ColumnIndex].Name == "btneliminar")
            {
                int indice = e.RowIndex;

                if (indice >= 0)
                {
                    string mensaje = string.Empty;
                    bool respuesta = new CN_Venta().SumarStock(
                        Convert.ToInt32(dgvproducto.Rows[indice].Cells["IdProducto"].Value.ToString()),
                        Convert.ToInt32(dgvproducto.Rows[indice].Cells["Cantidad"].Value.ToString())
                        );
                    if (respuesta)
                    {
                        calcularTotal();
                        dgvproducto.Rows.RemoveAt(indice);
                    }
                }
            }
        }

        private void txtprecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                if (txtprecio.Text.Trim().Length == 0 && e.KeyChar.ToString() == ".")
                {
                    e.Handled = false;
                }
                else
                {
                    if (Char.IsControl(e.KeyChar) || e.KeyChar.ToString() == ".")
                    {
                        e.Handled = false;
                    }
                    else
                    {
                        e.Handled = true;
                    }
                }
            }
        }

        private void txtpagacon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                if (txtpagacon.Text.Trim().Length == 0 && e.KeyChar.ToString() == ".")
                {
                    e.Handled = false;
                }
                else
                {
                    if (Char.IsControl(e.KeyChar) || e.KeyChar.ToString() == ".")
                    {
                        e.Handled = false;
                    }
                    else
                    {
                        e.Handled = true;
                    }
                }
            }
        }

        private void CalcularCambio()
        {
            if (txttotalpagar.Text.Trim() == "")
            {
                MessageBox.Show("No existen productos en la venta\n", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtproducto.Select();
                return;
            }

            decimal pagacon;
            decimal total = Convert.ToDecimal(txttotalpagar.Text);

            if (txtpagacon.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar el monto de pago\n", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtpagacon.Text = "";
            }

            if (decimal.TryParse(txtpagacon.Text.Trim(), out pagacon))
            {
                if (pagacon < total)
                {
                    MessageBox.Show("El pago debe ser igual o mayor que el total a pagar\n", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtpagacon.Select();
                    txtcambio.Text = "0.00";
                    txtpagacon.Text = "";
                    return;
                }
                else
                {
                    decimal cambio = pagacon - total;
                    txtcambio.Text = cambio.ToString("0.00");
                }
            }
            else
            {
                MessageBox.Show("Error al convertir el monto de pago\nPor favor, intentelo de nuevo", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtpagacon.Text = "";
            }
        }

        private void txtpagacon_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                CalcularCambio();
            }
        }

        private void btnregistrar_Click(object sender, EventArgs e)
        {
            if (txtdoccliente.Text == "")
            {
                MessageBox.Show("Debe de ingresar el documento del cliente\n", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (txtnombrecliente.Text == "")
            {
                MessageBox.Show("Debe de ingresar el nombre del cliente\n", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (dgvproducto.Rows.Count < 1)
            {
                MessageBox.Show("Debe agregar al menos un producto para registrar una venta\n", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DataTable detalle_venta = new DataTable();

            detalle_venta.Columns.Add("IdProducto", typeof(int));
            detalle_venta.Columns.Add("PrecioVenta", typeof(decimal));
            detalle_venta.Columns.Add("Cantidad", typeof(int));
            detalle_venta.Columns.Add("SubTotal", typeof(decimal));

            foreach (DataGridViewRow row in dgvproducto.Rows)
            {
                detalle_venta.Rows.Add(
                    new Object[]
                {
                    row.Cells["IdProducto"].Value.ToString(),
                    row.Cells["Precio"].Value.ToString(),
                    row.Cells["Cantidad"].Value.ToString(),
                    row.Cells["SubTotal"].Value.ToString()
                });
            }

            int idcorrelativo = new CN_Venta().ObtenerCorrelativo();
            string numerodocumento = string.Format("{0:00000}", idcorrelativo);
            CalcularCambio();
            try
            {
                Venta oVenta = new Venta()
                {
                    OUsuario = new Usuario() { IdUsuario = _Usuario.IdUsuario },
                    TipoDocumento = ((OpcionCombo)cbotipodocumento.SelectedItem).Texto,
                    NumeroDocumento = numerodocumento,
                    DocumentoCliente = txtdoccliente.Text,
                    NombreCliente = txtnombrecliente.Text,
                    MontoPago = Convert.ToDecimal(txtpagacon.Text),
                    MontoCambio = Convert.ToDecimal(txtcambio.Text),
                    MontoTotal = Convert.ToDecimal(txttotalpagar.Text)
                };

                string mensaje = string.Empty;
                bool respuesta = new CN_Venta().Registrar(oVenta, detalle_venta, out mensaje);

                if (respuesta)
                {
                    var result = MessageBox.Show("Numero de compra generada:\n" + numerodocumento + "\n\n¿Desea copiar al portapapeles?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                    if (result == DialogResult.Yes)
                    {
                        Clipboard.SetText(numerodocumento);
                    }

                    txtdoccliente.Text = "";
                    txtnombrecliente.Text = "";
                    dgvproducto.Rows.Clear();
                    calcularTotal();
                    txtpagacon.Text = "";
                    txtcambio.Text = "";
                }
                else
                {
                    MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show("Error al registrar la venta\nPor favor, intentelo de nuevo", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txtcodigoproducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Esto indica que el evento ha sido manejado y el carácter no será procesado
            }
            else
            {
                e.Handled = false;
            }
        }

        private void txtcantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Esto indica que el evento ha sido manejado y el carácter no será procesado
            }
            else
            {
                e.Handled = false;
            }
        }

        private void cbimpuesto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbimpuesto.SelectedIndex == 0)
            {
                EstablecerImpuestos(new ImpuestoReducido());
            }
            else if (cbimpuesto.SelectedIndex == 1)
            {
                EstablecerImpuestos(new ImpuestoEstandar());
            }
            else if (cbimpuesto.SelectedIndex == 2)
            {
                EstablecerImpuestos(new ImpuestoSuperior());
            }
            else if (cbimpuesto.SelectedIndex == 3)
            {
                EstablecerImpuestos(new ImpuestoSinDescuento());
            }
        }
    }
}
