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
    public partial class frmPermiso : Form
    {
        private CN_Permiso objcn_Permiso = new CN_Permiso();
        private Usuario UsuarioActual;
        public frmPermiso(Usuario oUsuario)
        {
            UsuarioActual = oUsuario;
            InitializeComponent();
        }

        private void frmPermiso_Load(object sender, EventArgs e)
        {
            foreach (DataGridViewColumn columna in dgvdata.Columns)
            {
                if (columna.Visible && columna.Name != "btnseleccionar")
                {
                    cbbusqueda.Items.Add(new OpcionCombo() { Texto = columna.Name, Valor = columna.HeaderText });
                }
            }
            cbbusqueda.SelectedIndex = 0;
            cbbusqueda.DisplayMember = "Texto";
            cbbusqueda.ValueMember = "Valor";


            //MOSTRAR LOS BOTONES SEGUN EL PERMISO
            List<Permiso> listaPermisos = UsuarioActual.GetPermisos();
            List<Button> listaBotones = new List<Button> { btneditarestado, btnverdetallepermisosimple };

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

            dgvdata.Rows.Clear();

            //MOSTRAR LOS PERMISOS
            List<Permiso> listPermisos = objcn_Permiso.ListarPermisos();
            listPermisos = listPermisos.OrderBy(p => p.Nombre).ToList();

            foreach (Permiso oPermiso in listPermisos)
            {
                dgvdata.Rows.Add(
                    "",
                    oPermiso.IdPermiso,
                    oPermiso.IdComponente,
                    oPermiso.Nombre,
                    oPermiso.NombreMenu,
                    oPermiso.Estado == true ? 1 : 0,
                    oPermiso.Estado == true ? "Activo" : "No Activo"
                    );
            }

            dgvdata.ClearSelection();

            txtid.Text = "";
            txtidcomponente.Text = "";
        }

        private void btnverdetalle_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtid.Text.Trim() != "")
                {
                    int idPermiso = Convert.ToInt32(txtid.Text);

                    using (var modal = new MD_DetallePermisoSimple(idPermiso))
                    {
                        var resultado = modal.ShowDialog();
                    }
                    dgvdata.Rows.Clear();

                    //MOSTRAR LOS PERMISOS
                    List<Permiso> listaPermisos = objcn_Permiso.ListarPermisos();
                    listaPermisos = listaPermisos.OrderBy(p => p.Nombre).ToList();

                    foreach (Permiso oPermiso in listaPermisos)
                    {
                        dgvdata.Rows.Add(
                            "",
                            oPermiso.IdPermiso,
                            oPermiso.IdComponente,
                            oPermiso.Nombre,
                            oPermiso.NombreMenu,
                            oPermiso.Estado == true ? 1 : 0,
                            oPermiso.Estado == true ? "Activo" : "No Activo"
                            );
                    }

                    dgvdata.ClearSelection();

                    txtid.Text = "";
                    txtidcomponente.Text = "";
                }
                else
                {
                    MessageBox.Show("Debe seleccionar un permiso", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch
            {
                MessageBox.Show("Debe seleccionar un Permiso","Error",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
        }

        private void btneditarestado_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtid.Text.Trim() != "")
                {
                    string estado = dgvdata.Rows[dgvdata.CurrentRow.Index].Cells["EstadoValor"].Value.ToString();
                    string nuevoEstado = string.Empty;
                    bool valorEstado = true;
                    if (estado == "Activo")
                    {
                        nuevoEstado = "Inactivo";
                        valorEstado = false;
                    }
                    else
                    {
                        nuevoEstado = "Activo";
                        valorEstado = true;
                    }

                    if (MessageBox.Show("¿Está seguro de cambiar el estado de permiso a " + nuevoEstado + "?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        string mensaje = string.Empty;

                        bool editado = objcn_Permiso.EditarEstado(Convert.ToInt32(txtidcomponente.Text), valorEstado, out mensaje);

                        if (editado)
                        {
                            MessageBox.Show("Estado editado correctamente.\nSe recomienda reiniciar el sistema", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            dgvdata.Rows.Clear();

                            //MOSTRAR LOS PERMISOS
                            List<Permiso> listaPermisos = objcn_Permiso.ListarPermisos();
                            listaPermisos = listaPermisos.OrderBy(p => p.Nombre).ToList();

                            foreach (Permiso oPermiso in listaPermisos)
                            {
                                dgvdata.Rows.Add(
                                    "",
                                    oPermiso.IdPermiso,
                                    oPermiso.IdComponente,
                                    oPermiso.Nombre,
                                    oPermiso.NombreMenu,
                                    oPermiso.Estado == true ? 1 : 0,
                                    oPermiso.Estado == true ? "Activo" : "No Activo"
                                    );
                            }

                            dgvdata.ClearSelection();

                            txtid.Text = "";
                            txtidcomponente.Text = "";
                        }
                        else
                        {
                            MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Debe seleccionar un permiso", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch
            {
                MessageBox.Show("Error al editar el estado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            string columnaFiltro = ((OpcionCombo)cbbusqueda.SelectedItem).Valor.ToString();

            if (dgvdata.Rows.Count > 0)
            {
                foreach (DataGridViewRow fila in dgvdata.Rows)
                {
                    if (fila.Cells[columnaFiltro].Value.ToString().Trim().ToUpper().Contains(txtbusqueda.Text.Trim().ToUpper()))
                    {
                        fila.Visible = true;
                    }
                    else
                    {
                        fila.Visible = false;
                    }
                }
            }
        }

        private void btnlimpiarbuscador_Click(object sender, EventArgs e)
        {
            txtbusqueda.Text = "";

            foreach (DataGridViewRow fila in dgvdata.Rows)
            {
                fila.Visible = true;
            }

            dgvdata.ClearSelection();
            txtid.Text = "";
        }

        private void dgvdata_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            if (e.ColumnIndex == 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                e.PaintBackground(e.ClipBounds, true);

                var w = Properties.Resources.check20.Width;
                var h = Properties.Resources.check20.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.check20, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
        }

        private void dgvdata_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;

            if (indice >= 0)
            {
                txtid.Text = dgvdata.Rows[indice].Cells["IdPermiso"].Value.ToString();
                txtidcomponente.Text = dgvdata.Rows[indice].Cells["IdComponente"].Value.ToString();
            }
        }

        private void dgvdata_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int indiceFila = e.RowIndex;
            int indiceColumna = e.ColumnIndex;

            if (indiceFila >= 0 && indiceColumna >= 0)
            {
                if (txtid.Text.Trim() != "")
                {
                    int idPermiso = Convert.ToInt32(txtid.Text);

                    using (var modal = new MD_DetallePermisoSimple(idPermiso))
                    {
                        var resultado = modal.ShowDialog();
                    }
                }
                else
                {
                    MessageBox.Show("Debe seleccionar un permiso", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
    }
}
