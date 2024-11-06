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
    public partial class frmGrupo : Form
    {
        CN_GrupoPermiso objcn_GrupoPermiso = new CN_GrupoPermiso();
        private Usuario UsuarioActual;
        public frmGrupo(Usuario oUsuario)
        {
            UsuarioActual = oUsuario;
            InitializeComponent();
        }

        private void frmGrupo_Load(object sender, EventArgs e)
        {
            //CONFIGURACION DEL OPCION COMBO SELECCIONAR
            foreach (DataGridViewColumn columna in dgvdata.Columns)
            {
                if (columna.Visible && columna.Name != "btnseleccionar")
                {
                    cbbusqueda.Items.Add(new OpcionCombo() { Valor = columna.Name, Texto = columna.HeaderText });
                }
            }
            cbbusqueda.SelectedIndex = 0;
            cbbusqueda.DisplayMember = "Texto";
            cbbusqueda.ValueMember = "Valor";


            //MOSTRAR LOS BOTONES SEGUN EL PERMISO
            List<Permiso> listaPermisos = UsuarioActual.GetPermisos();
            List<Button> listaBotones = new List<Button> { btnagregargrupo, btneditargrupo, btneliminargrupo, btnverdetallegrupo };

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

            //MOSTRAR LOS GRUPOS
            List<GrupoPermiso> listaGrupoPermisos = objcn_GrupoPermiso.ListarGrupoPermisos();
            listaGrupoPermisos = listaGrupoPermisos.OrderBy(p => p.Nombre).ToList();

            foreach (GrupoPermiso oGrupoPermiso in listaGrupoPermisos)
            {
                dgvdata.Rows.Add(
                    "",
                    oGrupoPermiso.IdGrupoPermiso,
                    oGrupoPermiso.IdComponente,
                    oGrupoPermiso.Nombre,
                    oGrupoPermiso.Estado == true ? 1 : 0,
                    oGrupoPermiso.Estado == true ? "Activo" : "Inactivo"
                    );
            }

            //CONFIGURA QUE NO ESTE SELECCIONADA NINGUNA FILA
            dgvdata.ClearSelection();

            txtid.Text = "";
            txtidcomponente.Text = "";
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
                txtid.Text = dgvdata.Rows[indice].Cells["IdGrupoPermiso"].Value.ToString();
                txtidcomponente.Text = dgvdata.Rows[indice].Cells["IdComponente"].Value.ToString();
            }
        }

        private void dgvdata_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int indiceFila = e.RowIndex;
            int indiceColumna = e.ColumnIndex;

            if (indiceFila >= 0 && indiceColumna >= 0)
            {
                btnverdetalle_Click(sender, e);
            }
        }

        private void btnverdetalle_Click(object sender, EventArgs e)
        {
            if (txtid.Text != "")
            {
                using (var modal = new MD_DetalleGrupoPermiso("VerDetalle", Convert.ToInt32(txtid.Text)))
                {
                    var resultado = modal.ShowDialog();

                    if (resultado == DialogResult.OK)
                    {
                        dgvdata.Rows.Clear();

                        //MOSTRAR LOS GRUPOS
                        List<GrupoPermiso> listaGrupoPermisos = objcn_GrupoPermiso.ListarGrupoPermisos();
                        listaGrupoPermisos = listaGrupoPermisos.OrderBy(p => p.Nombre).ToList();

                        foreach (GrupoPermiso oGrupoPermiso in listaGrupoPermisos)
                        {
                            dgvdata.Rows.Add(
                                "",
                                oGrupoPermiso.IdGrupoPermiso,
                                oGrupoPermiso.IdComponente,
                                oGrupoPermiso.Nombre,
                                oGrupoPermiso.Estado == true ? 1 : 0,
                                oGrupoPermiso.Estado == true ? "Activo" : "Inactivo"
                                );
                        }

                        //CONFIGURA QUE NO ESTE SELECCIONADA NINGUNA FILA
                        dgvdata.ClearSelection();

                        txtid.Text = "";
                        txtidcomponente.Text = "";
                    }
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un grupo", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            using (var modal = new MD_DetalleGrupoPermiso("Agregar", 0))
            {
                var resultado = modal.ShowDialog();

                if (resultado == DialogResult.OK)
                {
                    dgvdata.Rows.Clear();

                    //MOSTRAR LOS GRUPOS
                    List<GrupoPermiso> listaGrupoPermisos = objcn_GrupoPermiso.ListarGrupoPermisos();
                    listaGrupoPermisos = listaGrupoPermisos.OrderBy(p => p.Nombre).ToList();

                    foreach (GrupoPermiso oGrupoPermiso in listaGrupoPermisos)
                    {
                        dgvdata.Rows.Add(
                            "",
                            oGrupoPermiso.IdGrupoPermiso,
                            oGrupoPermiso.IdComponente,
                            oGrupoPermiso.Nombre,
                            oGrupoPermiso.Estado == true ? 1 : 0,
                            oGrupoPermiso.Estado == true ? "Activo" : "Inactivo"
                            );
                    }

                    //CONFIGURA QUE NO ESTE SELECCIONADA NINGUNA FILA
                    dgvdata.ClearSelection();

                    txtid.Text = "";
                    txtidcomponente.Text = "";
                }
            }
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            try
            {
                using (var modal = new MD_DetalleGrupoPermiso("Editar", Convert.ToInt32(txtid.Text)))
                {
                    var resultado = modal.ShowDialog();

                    if (resultado == DialogResult.OK)
                    {
                        dgvdata.Rows.Clear();

                        //MOSTRAR LOS GRUPOS
                        List<GrupoPermiso> listaGrupoPermisos = objcn_GrupoPermiso.ListarGrupoPermisos();
                        listaGrupoPermisos = listaGrupoPermisos.OrderBy(p => p.Nombre).ToList();

                        foreach (GrupoPermiso oGrupoPermiso in listaGrupoPermisos)
                        {
                            dgvdata.Rows.Add(
                                "",
                                oGrupoPermiso.IdGrupoPermiso,
                                oGrupoPermiso.IdComponente,
                                oGrupoPermiso.Nombre,
                                oGrupoPermiso.Estado == true ? 1 : 0,
                                oGrupoPermiso.Estado == true ? "Activo" : "Inactivo"
                                );
                        }

                        //CONFIGURA QUE NO ESTE SELECCIONADA NINGUNA FILA
                        dgvdata.ClearSelection();

                        txtid.Text = "";
                        txtidcomponente.Text = "";
                    }
                }
            }
            catch
            {
                MessageBox.Show("Debe seleccionar un Permiso", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
            txtidcomponente.Text = "";
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtid.Text != "" && txtidcomponente.Text != "")
                {
                    DialogResult resultado = MessageBox.Show("¿Está seguro de eliminar el grupo?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (resultado == DialogResult.Yes)
                    {
                        GrupoPermiso oGrupoPermiso = new GrupoPermiso();
                        oGrupoPermiso.IdGrupoPermiso = Convert.ToInt32(txtid.Text);
                        oGrupoPermiso.IdComponente = Convert.ToInt32(txtidcomponente.Text);

                        string mensaje;
                        bool respuesta = objcn_GrupoPermiso.EliminarGrupoPermiso(oGrupoPermiso, out mensaje);

                        if (respuesta)
                        {
                            MessageBox.Show("Grupo eliminado correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            dgvdata.Rows.Clear();

                            List<GrupoPermiso> listaGrupoPermisos = objcn_GrupoPermiso.ListarGrupoPermisos();
                            listaGrupoPermisos = listaGrupoPermisos.OrderBy(p => p.Nombre).ToList();

                            foreach (GrupoPermiso oGP in listaGrupoPermisos)
                            {
                                dgvdata.Rows.Add(
                                    "",
                                    oGP.IdGrupoPermiso,
                                    oGP.IdComponente,
                                    oGP.Nombre,
                                    oGP.Estado == true ? 1 : 0,
                                    oGP.Estado == true ? "Activo" : "Inactivo"
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
                    MessageBox.Show("Debe seleccionar un grupo", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch
            {

            }            
        }
    }
}
