using CapaPresentacion.Utilidades;
using CapaEntidad;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatos;
using CapaPresentacion.Modales;

namespace CapaPresentacion
{
    public partial class frmSeguridad : Form
    {
        private Usuario _usuarioActual;
        public frmSeguridad(Usuario oUsuario)
        {
            _usuarioActual = oUsuario;
            InitializeComponent();

        }
        public frmSeguridad()
        {
            InitializeComponent();
        }

        private void frmSeguridad_Load(object sender, EventArgs e)
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

            //MOSTRAR TODOS LOS USUARIOS
            List<Usuario> listaUsuario = new CN_Usuario().Listar();

            foreach (Usuario item in listaUsuario)
            {
                dgvdata.Rows.Add(new object[] {"", item.IdUsuario, item.Documento, item.NombreCompleto,
                item.Correo, item.Clave,
                item.Estado == true ? 1 : 0,
                item.Estado == true ? "Activo" : "No Activo"});
            }

            //MOSTRAR BOTONES SEGUN EL PERMISO
            List<Permiso> listaPermisos = _usuarioActual.GetPermisos();
            List<Button> listaBotones = new List<Button> { btnguardarusuario, btneliminarusuario, btnverpermisos, btngestionarpermisos };

            foreach(Button boton in listaBotones)
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

        private TextBox GetTxtindice()
        {
            return txtindice;
        }

        private void Limpiar()
        {
            txtindice.Text = "-1";
            txtid.Text = "";
            txtdocumento.Text = "";
            txtnombrecompleto.Text = "";
            txtcorreo.Text = "";
            txtclave.Text = "";
            txtconfirmarclave.Text = "";
            cbestado.SelectedIndex = 0;

            txtdocumento.Select();
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

                    txtid.Text = dgvdata.Rows[indice].Cells["IdUsuario"].Value.ToString();
                    txtdocumento.Text = dgvdata.Rows[indice].Cells["Documento"].Value.ToString();
                    txtnombrecompleto.Text = dgvdata.Rows[indice].Cells["NombreCompleto"].Value.ToString();
                    txtcorreo.Text = dgvdata.Rows[indice].Cells["Correo"].Value.ToString();
                    txtclave.Text = dgvdata.Rows[indice].Cells["Clave"].Value.ToString();
                    txtconfirmarclave.Text = dgvdata.Rows[indice].Cells["Clave"].Value.ToString();

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

        private void btnguardarusuario_Click_1(object sender, EventArgs e)
        {
            string mensaje = string.Empty;

            try
            {
                Usuario objusuario = new Usuario()
                {
                    IdUsuario = Convert.ToInt32(txtid.Text),
                    Documento = txtdocumento.Text,
                    NombreCompleto = txtnombrecompleto.Text,
                    Correo = txtcorreo.Text,
                    Clave = txtclave.Text,
                    Estado = Convert.ToInt32(((OpcionCombo)cbestado.SelectedItem).Valor) == 1 ? true : false
                };

                if (objusuario.IdUsuario == 0)
                {
                    int idusuariogenerado = new CN_Usuario().Registrar(objusuario, out mensaje);

                    if (idusuariogenerado != 0)
                    {
                        dgvdata.Rows.Add(new object[] {"", idusuariogenerado, txtdocumento.Text, txtnombrecompleto.Text,
                    txtcorreo.Text, txtclave.Text,
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
                    bool resultado = new CN_Usuario().Editar(objusuario, out mensaje);

                    if (resultado)
                    {
                        DataGridViewRow row = dgvdata.Rows[Convert.ToInt32(txtindice.Text)];
                        row.Cells["IdUsuario"].Value = txtid.Text;
                        row.Cells["Documento"].Value = txtdocumento.Text;
                        row.Cells["NombreCompleto"].Value = txtnombrecompleto.Text;
                        row.Cells["Correo"].Value = txtcorreo.Text;
                        row.Cells["Clave"].Value = txtclave.Text;
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
                MessageBox.Show("Debe completar los campos o seleccionar un Usuario", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }            
        }

        private void btnlimpiar_Click_1(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btneliminarusuario_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(txtid.Text) != 0)
                {
                    if (MessageBox.Show("¿Desea eliminar el usuario?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        string mensaje = string.Empty;
                        Usuario objusuario = new Usuario()
                        {
                            IdUsuario = Convert.ToInt32(txtid.Text)
                        };

                        bool respuesta = new CN_Usuario().Eliminar(objusuario, out mensaje);

                        if (respuesta)
                        {
                            dgvdata.Rows.RemoveAt(Convert.ToInt32(txtindice.Text));
                        }
                        else
                        {
                            MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Debe de seleccionar un Usuario antes de eliminar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Debe de seleccionar un Usuario antes de eliminar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnverpermisos_Click_1(object sender, EventArgs e)
        {
            if (txtid.Text.Trim() != "")
            {
                using (var modal = new MD_DetallePermisoUsuario("VerDetalle", Convert.ToInt32(txtid.Text)))
                {
                    var result = modal.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un Usuario", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btngestionarpermisos_Click_1(object sender, EventArgs e)
        {
            if (txtid.Text.Trim() != "")
            {
                using (var modal = new MD_DetallePermisoUsuario("Editar", Convert.ToInt32(txtid.Text)))
                {
                    var result = modal.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un Usuario", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

        private void txtcorreo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != '@' && e.KeyChar != '.' && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Esto indica que el evento ha sido manejado y el carácter no será procesado
            }
            else
            {
                e.Handled = false;
            }
        }

        private void txtdocumento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Esto indica que el evento ha sido manejado y el carácter no será procesado
            }
            else
            {
                e.Handled = false;
            }
        }

        private void txtnombrecompleto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
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
