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

namespace CapaPresentacion.Modales
{
    public partial class MD_DetallePermisoUsuario : Form
    {
        private readonly string _tipoModal;
        private int _idUsuario;
        private Usuario _oUsuario;
        private CN_Usuario objcn_Usuario = new CN_Usuario();
        private CN_UsuarioPermiso objcn_UsuarioPermiso = new CN_UsuarioPermiso();
        public MD_DetallePermisoUsuario(string tipoModal, int idUsuario)
        {
            _tipoModal = tipoModal;
            _idUsuario = idUsuario;
            _oUsuario = objcn_Usuario.Listar().Where(u => u.IdUsuario == _idUsuario).FirstOrDefault();
            InitializeComponent();
        }

        private void MD_DetallePermisoUsuario_Load(object sender, EventArgs e)
        {
            cbestado.Items.Add(new OpcionCombo() { Valor = 1, Texto = "Activo" }); ;
            cbestado.Items.Add(new OpcionCombo() { Valor = 0, Texto = "No Activo" }); ;
            cbestado.SelectedIndex = 0;
            cbestado.DisplayMember = "Texto";
            cbestado.ValueMember = "Valor";

            dgvdata.Rows.Clear();

            txtnombrecompleto.Focus();

            switch (_tipoModal)
            {
                case "VerDetalle":
                    ConfigurarVerDetalle();
                    break;
                case "Editar":
                    ConfigurarEditar();
                    break;
            };
        }
        private void ConfigurarVerDetalle()
        {
            try
            {
                this.Text = "Ver detalle de usuario";
                txtnombrecompleto.Text = _oUsuario.NombreCompleto.ToString();
                txtnombrecompleto.Enabled = false;
                cbestado.Enabled = false;
                btnagregarpermiso.Visible = false;
                btneliminarpermiso.Visible = false;
                btnguardarpermiso.Visible = false;

                foreach (OpcionCombo opcion in cbestado.Items)
                {
                    if (Convert.ToInt32(opcion.Valor) == (_oUsuario.Estado == true ? 1 : 0))
                    {
                        int indiceCombo = cbestado.Items.IndexOf(opcion);
                        cbestado.SelectedIndex = indiceCombo;
                        break;
                    }
                }

                MostrarPermisos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Debe seleccionar un Usuario", "Mensaje" ,MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ConfigurarEditar()
        {
            try
            {
                this.Text = "Administrar permisos del usuario";
                lbltitulo.Text = "Administrar permisos del usuario";
                btnguardarpermiso.Text = "Guardar Permisos";
                txtnombrecompleto.ReadOnly = false;
                txtnombrecompleto.Text = _oUsuario.NombreCompleto.ToString();
                txtnombrecompleto.Enabled = false;
                cbestado.Enabled = false;

                foreach (OpcionCombo opcion in cbestado.Items)
                {
                    if (Convert.ToInt32(opcion.Valor) == (_oUsuario.Estado == true ? 1 : 0))
                    {
                        int indiceCombo = cbestado.Items.IndexOf(opcion);
                        cbestado.SelectedIndex = indiceCombo;
                        break;
                    }
                }

                MostrarPermisos();
            }
            catch
            {
                MessageBox.Show("Debe seleccionar un Usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void MostrarPermisos()
        {
            //MOSTRAR LOS PERMISOS
            List<Componente> listaComponentes = objcn_UsuarioPermiso.ListarComponente(_idUsuario);

            foreach (Componente oComponente in listaComponentes)
            {
                dgvdata.Rows.Add(
                    "",
                    oComponente.IdComponente,
                    oComponente.Nombre,
                    oComponente.TipoComponente,
                    oComponente.Estado == true ? 1 : 0,
                    oComponente.Estado == true ? "Activo" : "Inactivo"
                    );
            }

            //CONFIGURA QUE NO ESTE SELECCIONADA NINGUNA FILA
            dgvdata.ClearSelection();
        }

        private void dgvdata_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;

            if (indice >= 0)
            {
                txtid.Text = dgvdata.Rows[indice].Cells["IdComponente"].Value.ToString();
            }
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

        private void btnagregarpermiso_Click(object sender, EventArgs e)
        {
            using (var modal = new MD_AgregarComponenteAGrupo())
            {
                try
                {
                    var resultado = modal.ShowDialog();

                    if (resultado == DialogResult.OK)
                    {
                        txtid.Text = modal.oComponente.IdComponente.ToString();

                        foreach (DataGridViewRow row in dgvdata.Rows)
                        {
                            if (row.Cells["IdComponente"].Value.ToString() == txtid.Text)
                            {
                                MessageBox.Show("El componente ya se encuentra en la lista", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }

                        dgvdata.Rows.Add(
                            "",
                            modal.oComponente.IdComponente,
                            modal.oComponente.Nombre,
                            modal.oComponente.TipoComponente,
                            modal.oComponente.Estado == true ? 1 : 0,
                            modal.oComponente.Estado == true ? "Activo" : "Inactivo"
                            );
                    }
                    dgvdata.ClearSelection();
                    txtid.Text = "";
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }
        }

        private void btneliminarpermiso_Click(object sender, EventArgs e)
        {
            try
            {
                int indice = dgvdata.CurrentRow.Index;

                if (indice >= 0)
                {
                    dgvdata.Rows.RemoveAt(indice);
                }

                dgvdata.ClearSelection();
                txtid.Text = "";
            }
            catch
            {
                MessageBox.Show("Debes de seleccionar un permiso para eliminarlo", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnguardarpermiso_Click(object sender, EventArgs e)
        {
            if (dgvdata.Rows.Count == 0)
            {
                MessageBox.Show("Debe agregar al menos un permiso", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DataTable listaComponentes = new DataTable();

            listaComponentes.Columns.Add("IdComponente", typeof(int));

            foreach (DataGridViewRow row in dgvdata.Rows)
            {
                listaComponentes.Rows.Add(Convert.ToInt32(row.Cells["IdComponente"].Value));
            }

            bool resultado = objcn_UsuarioPermiso.EditrarUsuarioPermiso(_idUsuario, listaComponentes, out string mensaje);

            if (resultado)
            {
                MessageBox.Show("Usuario editado correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show(mensaje, "Error al editar el Permiso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
