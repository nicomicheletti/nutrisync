using CapaDatos;
using CapaEntidad;
using CapaNegocio;
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
    public partial class frmProducto : Form
    {
        private Usuario _usuarioActual;
        public frmProducto(Usuario oUsuario)
        {
            _usuarioActual = oUsuario;
            InitializeComponent();
        }

        private void frmProducto_Load(object sender, EventArgs e)
        {
            cbestado.Items.Add(new OpcionCombo() { Valor = 1, Texto = "Activo" });
            cbestado.Items.Add(new OpcionCombo() { Valor = 0, Texto = "No Activo" });

            cbestado.DisplayMember = "Texto";
            cbestado.ValueMember = "Valor";
            cbestado.SelectedIndex = 0;


            List<Categoria> listaCategoria = new CN_Categoria().Listar();

            foreach (Categoria item in listaCategoria)
            {
                cbcategoria.Items.Add(new OpcionCombo() { Valor = item.IdCategoria, Texto = item.Descripcion });
            }

            cbcategoria.DisplayMember = "Texto";
            cbcategoria.ValueMember = "Valor";
            cbcategoria.SelectedIndex = 0;

            foreach (DataGridViewColumn columna in dgvdata.Columns)
            {
                if (columna.Visible == true && columna.Name != "btnSeleccionar")
                {
                    cbbusqueda.Items.Add(new OpcionCombo() { Valor = columna.Name, Texto = columna.HeaderText });
                }
            }

            cbbusqueda.DisplayMember = "Texto";
            cbbusqueda.ValueMember = "Valor";
            cbbusqueda.SelectedIndex = 0;

            //MOSTRAR TODOS LOS PRODUCTOS
            List<Producto> lista = new CN_Producto().Listar();

            foreach (Producto item in lista)
            {
                dgvdata.Rows.Add(new object[] {
                    "",
                    item.IdProducto,
                    item.Codigo,
                    item.Nombre,
                    item.Descripcion,
                    item.OCategoria.IdCategoria,
                    item.OCategoria.Descripcion,
                    item.Stock,
                    item.PrecioCompra,
                    item.PrecioVenta,
                    item.Estado == true ? 1 : 0 ,
                    item.Estado == true ? "Activo" : "No Activo"});
            }

            //MOSTRAR LOS BOTONES SEGUN EL PERMISO
            List<Permiso> listaPermisos = _usuarioActual.GetPermisos();
            List<Button> listaBotones = new List<Button> { btnguardarproducto, btneliminarproducto };

            foreach (Button boton in listaBotones)
            {
                bool encontrado = listaPermisos.Any(p => p.NombreMenu == boton.Name);

                if (encontrado)
                {
                    boton.Visible = true;
                }
                else
                {
                    boton.Visible = false;
                }
            }

        }

        private void Limpiar()
        {
            txtindice.Text = "-1";
            txtid.Text = "";
            txtcodigo.Text = "";
            txtnombre.Text = "";
            txtdescripcion.Text = "";
            cbcategoria.SelectedIndex = 0;
            cbestado.SelectedIndex = 0;

            txtcodigo.Select();
        }

        private void dgvdata_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (e.ColumnIndex == 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var w = Properties.Resources.check20.Width;
                var h = Properties.Resources.check20.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.check20, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
        }


        private void dgvdata_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvdata.Columns[e.ColumnIndex].Name == "btnSeleccionar")
            {
                int indice = e.RowIndex;

                if (indice >= 0)
                {
                    txtindice.Text = indice.ToString();

                    txtid.Text = dgvdata.Rows[indice].Cells["Id"].Value.ToString();
                    txtcodigo.Text = dgvdata.Rows[indice].Cells["Codigo"].Value.ToString();
                    txtnombre.Text = dgvdata.Rows[indice].Cells["Nombre"].Value.ToString();
                    txtdescripcion.Text = dgvdata.Rows[indice].Cells["Descripcion"].Value.ToString();

                    foreach (OpcionCombo oc in cbcategoria.Items)
                    {
                        if (Convert.ToInt32(oc.Valor) == Convert.ToInt32(dgvdata.Rows[indice].Cells["IdCategoria"].Value))
                        {
                            int indice_combo = cbcategoria.Items.IndexOf(oc);
                            cbcategoria.SelectedIndex = indice_combo;
                            break;
                        }
                    }

                    foreach (OpcionCombo oc in cbestado.Items)
                    {
                        if (Convert.ToInt32(oc.Valor) == Convert.ToInt32(dgvdata.Rows[indice].Cells["EstadoValor"].Value))
                        {
                            int indice_combo = cbestado.Items.IndexOf(oc);
                            cbestado.SelectedIndex = indice_combo;
                            break;
                        }
                    }
                }
            }
        }

        private void btnbuscar_Click_1(object sender, EventArgs e)
        {
            string columnafiltro = ((OpcionCombo)cbbusqueda.SelectedItem).Valor.ToString();

            if (dgvdata.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvdata.Rows)
                {
                    if (row.Cells[columnafiltro].Value.ToString().Trim().ToUpper().Contains(txtbusqueda.Text.Trim().ToUpper()))
                    {
                        row.Visible = true;
                    }
                    else
                    {
                        row.Visible = false;
                    }
                }
            }
        }

        private void btnlimpiarbuscador_Click_1(object sender, EventArgs e)
        {
            txtbusqueda.Text = "";
            foreach (DataGridViewRow row in dgvdata.Rows)
            {
                row.Visible = true;
            }
        }

        private void btnguardar_Click_1(object sender, EventArgs e)
        {
            try
            {
                string mensaje = string.Empty;

                Producto objproducto = new Producto()
                {
                    IdProducto = Convert.ToInt32(txtid.Text),
                    Codigo = txtcodigo.Text,
                    Nombre = txtnombre.Text,
                    Descripcion = txtdescripcion.Text,
                    OCategoria = new Categoria() { IdCategoria = Convert.ToInt32(((OpcionCombo)cbcategoria.SelectedItem).Valor) },
                    Estado = Convert.ToInt32(((OpcionCombo)cbestado.SelectedItem).Valor) == 1 ? true : false
                };

                if (objproducto.IdProducto == 0)
                {
                    int idproductogenerado = new CN_Producto().Registrar(objproducto, out mensaje);

                    if (idproductogenerado != 0)
                    {
                        dgvdata.Rows.Add(new object[] {
                            "",
                            idproductogenerado,
                            txtcodigo.Text,
                            txtnombre.Text,
                            txtdescripcion.Text,
                            ((OpcionCombo)cbcategoria.SelectedItem).Valor.ToString(),
                            ((OpcionCombo)cbcategoria.SelectedItem).Texto.ToString(),
                            "0",
                            "0.00",
                            "0.00",
                            ((OpcionCombo)cbestado.SelectedItem).Valor.ToString(),
                            ((OpcionCombo)cbestado.SelectedItem).Texto.ToString(),});

                        Limpiar();
                    }
                    else
                    {
                        MessageBox.Show(mensaje);
                    }
                }
                else
                {
                    bool resultado = new CN_Producto().Editar(objproducto, out mensaje);

                    if (resultado)
                    {
                        DataGridViewRow row = dgvdata.Rows[Convert.ToInt32(txtindice.Text)];
                        row.Cells["Id"].Value = txtid.Text;
                        row.Cells["Codigo"].Value = txtcodigo.Text;
                        row.Cells["Nombre"].Value = txtnombre.Text;
                        row.Cells["Descripcion"].Value = txtdescripcion.Text;
                        row.Cells["IdCategoria"].Value = ((OpcionCombo)cbcategoria.SelectedItem).Valor.ToString();
                        row.Cells["Categoria"].Value = ((OpcionCombo)cbcategoria.SelectedItem).Texto.ToString();
                        row.Cells["EstadoValor"].Value = ((OpcionCombo)cbestado.SelectedItem).Valor.ToString();
                        row.Cells["Estado"].Value = ((OpcionCombo)cbestado.SelectedItem).Texto.ToString();

                        Limpiar();
                    }
                    else
                    {
                        MessageBox.Show(mensaje);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Error al guardar el Producto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btneliminar_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(txtid.Text) != 0)
                {
                    if (MessageBox.Show("¿Desea eliminar el producto?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        string mensaje = string.Empty;
                        Producto objproducto = new Producto()
                        {
                            IdProducto = Convert.ToInt32(txtid.Text)
                        };

                        bool respuesta = new CN_Producto().Eliminar(objproducto, out mensaje);

                        if (respuesta)
                        {
                            dgvdata.Rows.RemoveAt(Convert.ToInt32(txtindice.Text));

                            Limpiar();
                        }
                        else
                        {
                            MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Debe de seleccionar un Producto antes de eliminar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Error al editar el Producto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txtcodigo_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtnombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Esto indica que el evento ha sido manejado y el carácter no será procesado
            }
            else
            {
                e.Handled = false;
            }
        }

        private void txtdescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Esto indica que el evento ha sido manejado y el carácter no será procesado
            }
            else
            {
                e.Handled = false;
            }
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {

        }
    }
}
