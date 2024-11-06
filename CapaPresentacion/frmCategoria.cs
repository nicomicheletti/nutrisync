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
    public partial class frmCategoria : Form
    {
        private Usuario _usuarioActual;
        public frmCategoria(Usuario oUsuario)
        {
            InitializeComponent();
            _usuarioActual = oUsuario;
        }

        private void frmCategoria_Load(object sender, EventArgs e)
        {
            cbestado.Items.Add(new OpcionCombo() { Valor = 1, Texto = "Activo" });
            cbestado.Items.Add(new OpcionCombo() { Valor = 0, Texto = "No Activo" });

            cbestado.DisplayMember = "Texto";
            cbestado.ValueMember = "Valor";
            cbestado.SelectedIndex = 0;


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

            //MOSTRAR TODAS LAS CATEGORIAS
            List<Categoria> lista = new CN_Categoria().Listar();

            foreach (Categoria item in lista)
            {
                dgvdata.Rows.Add(new object[] {"", item.IdCategoria, item.Descripcion,
                item.Estado == true ? 1 : 0,
                item.Estado == true ? "Activo" : "No Activo"});
            }

            //MOSTRAR LOS BOTONES SEGUN EL PERMISO
            List<Permiso> listaPermisos = _usuarioActual.GetPermisos();
            List<Button> listaBotones = new List<Button> { btnguardarcategoria, btneliminarcategoria };

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

        private void btnguardar_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;

            try
            {
                Categoria objcategoria = new Categoria()
                {
                    IdCategoria = Convert.ToInt32(txtid.Text),
                    Descripcion = txtdescripcion.Text,
                    Estado = Convert.ToInt32(((OpcionCombo)cbestado.SelectedItem).Valor) == 1 ? true : false
                };

                if (objcategoria.IdCategoria == 0)
                {
                    int idcategoriagenerado = new CN_Categoria().Registrar(objcategoria, out mensaje);

                    if (idcategoriagenerado != 0)
                    {
                        dgvdata.Rows.Add(new object[] {"", idcategoriagenerado, txtdescripcion.Text,
                    ((OpcionCombo)cbestado.SelectedItem).Valor.ToString(),
                    ((OpcionCombo)cbestado.SelectedItem).Texto.ToString()});

                        Limpiar();
                    }
                    else
                    {
                        MessageBox.Show(mensaje);
                    }
                }
                else
                {
                    bool resultado = new CN_Categoria().Editar(objcategoria, out mensaje);

                    if (resultado)
                    {
                        DataGridViewRow row = dgvdata.Rows[Convert.ToInt32(txtindice.Text)];
                        row.Cells["IdCategoria"].Value = txtid.Text;
                        row.Cells["Descripcion"].Value = txtdescripcion.Text;
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
                MessageBox.Show("Debe completar los campos o seleccionar una categoria", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void Limpiar()
        {
            txtindice.Text = "-1";
            txtid.Text = "0";
            txtdescripcion.Text = "";
            cbestado.SelectedIndex = 0;

            txtdescripcion.Select();
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

                    txtid.Text = dgvdata.Rows[indice].Cells["IdCategoria"].Value.ToString();
                    txtdescripcion.Text = dgvdata.Rows[indice].Cells["Descripcion"].Value.ToString();

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

        private void btneliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(txtid.Text) != 0)
                {
                    if (MessageBox.Show("¿Desea eliminar la categoria?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        string mensaje = string.Empty;
                        Categoria objcategoria = new Categoria()
                        {
                            IdCategoria = Convert.ToInt32(txtid.Text)
                        };

                        bool respuesta = new CN_Categoria().Eliminar(objcategoria, out mensaje);

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
                    MessageBox.Show("Debe de seleccionar una Categoria antes de eliminar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Debe seleccionar un producto para eliminarlo", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnbuscar_Click(object sender, EventArgs e)
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

        private void btnlimpiarbuscador_Click(object sender, EventArgs e)
        {
            txtbusqueda.Text = "";
            foreach (DataGridViewRow row in dgvdata.Rows)
            {
                row.Visible = true;
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
    }
}
