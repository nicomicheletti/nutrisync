using CapaDatos;
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

namespace CapaPresentacion
{
    public partial class frmCompras : Form
    {
        private Usuario _Usuario;

        public frmCompras(Usuario oUsuario = null)
        {
            _Usuario = oUsuario;
            InitializeComponent();
        }

        private void frmCompras_Load(object sender, EventArgs e)
        {
            cbotipodocumento.Items.Add(new OpcionCombo() { Valor = "Boleta", Texto = "Boleta" });
            cbotipodocumento.Items.Add(new OpcionCombo() { Valor = "Factura", Texto = "Factura" });

            cbotipodocumento.DisplayMember = "Texto";
            cbotipodocumento.ValueMember = "Valor";
            cbotipodocumento.SelectedIndex = 0;

            cbimpuesto.Items.Add(new OpcionCombo() { Valor = "Reducido", Texto = "Reducido" });
            cbimpuesto.Items.Add(new OpcionCombo() { Valor = "Estandar", Texto = "Estandar" });
            cbimpuesto.Items.Add(new OpcionCombo() { Valor = "Superior", Texto = "Superior" });

            cbimpuesto.DisplayMember = "Texto";
            cbimpuesto.ValueMember = "Valor";
            cbimpuesto.SelectedIndex = 0;

            txtfecha.Text = DateTime.Now.ToString("dd/MM/yyyy");

            txtidproveedor.Text = "0";
            txtidproducto.Text = "0";

            txtcantidad.Maximum = 50000;

            txtpreciocompra.Text = "por kg";
            txtpreciocompra.ForeColor = Color.LightGray;

            txtprecioventa.Text = "por kg";
            txtprecioventa.ForeColor = Color.LightGray;
        }

        public interface Impuesto
        {
            decimal CalcularImpuesto(decimal total);
        }

        public class ImpuestoEstandar : Impuesto
        {
            public decimal CalcularImpuesto(decimal total)
            {
                return total * 1.15m;
            }
        }

        public class ImpuestoReducido : Impuesto
        {
            public decimal CalcularImpuesto(decimal total)
            {
                return total * 1.10m;
            }
        }

        public class ImpuestoSuperior : Impuesto
        {
            public decimal CalcularImpuesto(decimal total)
            {
                return total * 1.21m;
            }
        }

        private Impuesto _impuesto;

        public void EstablecerImpuestos(Impuesto strategy)
        {
            _impuesto = strategy;
        }

        private void btnregistrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(txtidproveedor.Text) == 0)
                {
                    MessageBox.Show("Debe seleccionar un Proveedor\n", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtdocproveedor.Select();
                    return;
                }

                if (dgvproducto.Rows.Count < 1)
                {
                    MessageBox.Show("Debe ingresar productos en la Compra\n", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtcodigoproducto.Select();
                    return;
                }

                DataTable detalle_compra = new DataTable();

                detalle_compra.Columns.Add("IdProducto", typeof(int));
                detalle_compra.Columns.Add("PrecioCompra", typeof(decimal));
                detalle_compra.Columns.Add("PrecioVenta", typeof(decimal));
                detalle_compra.Columns.Add("Cantidad", typeof(int));
                detalle_compra.Columns.Add("MontoTotal", typeof(decimal));

                foreach (DataGridViewRow row in dgvproducto.Rows)
                {
                    detalle_compra.Rows.Add(
                        new Object[]
                    {
                    Convert.ToInt32(row.Cells["IdProducto"].Value.ToString()),
                    row.Cells["PrecioCompra"].Value.ToString(),
                    row.Cells["PrecioVenta"].Value.ToString(),
                    row.Cells["Cantidad"].Value.ToString(),
                    row.Cells["SubTotal"].Value.ToString()
                    });
                }

                int idcorrelativo = new CN_Compra().ObtenerCorrelativo();
                string numerodocumento = string.Format("{0:00000}", idcorrelativo);

                Compra oCompra = new Compra()
                {
                    OUsuario = new Usuario() { IdUsuario = _Usuario.IdUsuario },
                    OProveedor = new Proveedor() { IdProveedor = Convert.ToInt32(txtidproveedor.Text) },
                    TipoDocumento = ((OpcionCombo)cbotipodocumento.SelectedItem).Texto,
                    NumeroDocumento = numerodocumento,
                    MontoTotal = Convert.ToDecimal(txttotal.Text)
                };

                string mensaje = string.Empty;
                bool respuesta = new CN_Compra().Registrar(oCompra, detalle_compra, out mensaje);

                if (respuesta)
                {
                    var result = MessageBox.Show("Numero de compra generada:\n" + numerodocumento + "\n\n¿Desea copiar al portapapeles?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                    if (result == DialogResult.Yes)
                    {
                        Clipboard.SetText(numerodocumento);
                    }

                    txtidproveedor.Text = "0";
                    txtdocproveedor.Text = "";
                    txtrazonsocial.Text = "";
                    txttotal.Text = "0.00";
                    dgvproducto.Rows.Clear();
                    calcularTotal();
                }
                else
                {
                    MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show("Error al registrar la compra\n\nIntentelo de nuevo", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbotipodocumento_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
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
                    txtpreciocompra.Select();
                }
                else
                {
                    txtcodigoproducto.Select();
                }
            }
        }

        private void dgvproducto_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (e.ColumnIndex == 6)
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
                    txtpreciocompra.Select();
                }
                else
                {
                    txtcodigoproducto.BackColor = Color.MistyRose;
                    txtidproducto.Text = "0";
                    txtproducto.Text = "";
                    txtcantidad.Value = 1;
                }
            }
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            decimal preciocompra = 0;
            decimal precioventa = 0;
            bool producto_existe = false;

            if (int.Parse(txtidproducto.Text) == 0)
            {
                MessageBox.Show("Debe de seleccionar un producto\n", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (!decimal.TryParse(txtpreciocompra.Text, out preciocompra))
            {
                MessageBox.Show("Precio Compra - Formato moneda incorrecto\n", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtpreciocompra.Select();
                return;
            }

            if (!decimal.TryParse(txtpreciocompra.Text, out precioventa))
            {
                MessageBox.Show("Precio Venta - Formato moneda incorrecto\n", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtprecioventa.Select();
                return;
            }

            if (cbimpuesto.Text == "")
            {
                MessageBox.Show("Debe de seleccionar un impuesto para el producto\n", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cbimpuesto.Select();
                return;
            }

            foreach (DataGridViewRow fila in dgvproducto.Rows)
            {
                if (fila.Cells["IdProducto"] != null && fila.Cells["IdProducto"].Value != null && fila.Cells["IdProducto"].Value.ToString() == txtidproducto.Text)
                {
                    producto_existe = true;
                    break;
                }

            }

            decimal impuesto;

            if (!producto_existe)
            {
                dgvproducto.Rows.Add(new object[]
                {
                    txtidproducto.Text,
                    txtproducto.Text,
                    preciocompra.ToString("0.00"),
                    precioventa.ToString("0.00"),
                    txtcantidad.Value.ToString(),
                    _impuesto.CalcularImpuesto(txtcantidad.Value * preciocompra).ToString("0.00")
                });

                limpiarProducto();
                calcularTotal();
                txtcodigoproducto.Select();
            }
        }

        private void limpiarProducto()
        {
            txtidproducto.Text = "0";
            txtcodigoproducto.Text = "";
            txtcodigoproducto.BackColor = Color.White;
            txtproducto.Text = "";
            txtpreciocompra.Text = "por kg";
            txtpreciocompra.ForeColor = Color.LightGray;
            txtprecioventa.Text = "por kg";
            txtprecioventa.ForeColor = Color.LightGray;
            txtcantidad.Value = 1;
            cbimpuesto.Text = "";
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
                        decimal impuesto = _impuesto.CalcularImpuesto(total);
                    }
                }
                txttotal.Text = total.ToString("0.00");
            }
        }

        private void dgvproducto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvproducto.Columns[e.ColumnIndex].Name == "btneliminar")
            {
                int indice = e.RowIndex;

                if (indice >= 0)
                {
                    dgvproducto.Rows.RemoveAt(indice);
                    calcularTotal();
                }
            }
        }

        private void txtpreciocompra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                if (txtpreciocompra.Text.Trim().Length == 0 && e.KeyChar.ToString() == ".")
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

        private void txtprecioventa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                if (txtprecioventa.Text.Trim().Length == 0 && e.KeyChar.ToString() == ".")
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

        private void txtpreciocompra_Click(object sender, EventArgs e)
        {
            txtpreciocompra.Text = "";
            txtpreciocompra.ForeColor = SystemColors.WindowText;
        }

        private void txtprecioventa_Click(object sender, EventArgs e)
        {
            txtprecioventa.Text = " ";
            txtprecioventa.ForeColor = SystemColors.WindowText;
        }

        private void btnbuscarprov_Click_1(object sender, EventArgs e)
        {
            using (var modal = new MD_Proveedor())
            {
                var result = modal.ShowDialog();

                if (result == DialogResult.OK)
                {
                    txtidproveedor.Text = modal._Proveedor.IdProveedor.ToString();
                    txtdocproveedor.Text = modal._Proveedor.Documento;
                    txtrazonsocial.Text = modal._Proveedor.RazonSocial;
                    txtcodigoproducto.Select();
                }
                else
                {
                    txtdocproveedor.Select();
                }
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
        }
    }
}
