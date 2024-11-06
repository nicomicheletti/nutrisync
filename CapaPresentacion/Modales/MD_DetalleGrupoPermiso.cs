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
    public partial class MD_DetalleGrupoPermiso : Form
    {
        private readonly string _tipoModal;
        private int _idGrupoPermiso;
        private GrupoPermiso _oGrupoPermiso;
        private CN_GrupoPermiso objcn_GrupoPermiso = new CN_GrupoPermiso();
        public MD_DetalleGrupoPermiso(string tipoModal, int idGrupoPermiso)
        {
            _tipoModal = tipoModal;
            _idGrupoPermiso = idGrupoPermiso;
            _oGrupoPermiso = objcn_GrupoPermiso.ListarGrupoPermisos().Where(c => c.IdGrupoPermiso == _idGrupoPermiso).FirstOrDefault();
            InitializeComponent();
        }

        private void MD_DetalleGrupoPermiso_Load(object sender, EventArgs e)
        {
            cbestado.Items.Add(new OpcionCombo() { Valor = 1, Texto = "Activo" }); ;
            cbestado.Items.Add(new OpcionCombo() { Valor = 0, Texto = "No Activo" }); ;
            cbestado.SelectedIndex = 0;
            cbestado.DisplayMember = "Texto";
            cbestado.ValueMember = "Valor";

            dgvdata.Rows.Clear();

            switch (_tipoModal)
            {
                case "VerDetalle":
                    ConfigurarVerDetalle();
                    break;
                case "Agregar":
                    ConfigurarAgregar();
                    break;
                case "Editar":
                    ConfigurarEditar();
                    break;
            };
        }
        private void ConfigurarVerDetalle()
        {
            this.Text = "Ver Detalle";
            txtnombregrupo.Text = _oGrupoPermiso.Nombre.ToString();
            txtnombregrupo.Enabled = false;
            cbestado.Enabled = false;
            btnagregarpermiso.Visible = false;
            btneliminarpermiso.Visible = false;
            btnguardarpermiso.Visible = false;
            txtnombregrupo.ReadOnly = true;

            foreach (OpcionCombo opcion in cbestado.Items)
            {
                if (Convert.ToInt32(opcion.Valor) == (_oGrupoPermiso.Estado == true ? 1 : 0))
                {
                    int indiceCombo = cbestado.Items.IndexOf(opcion);
                    cbestado.SelectedIndex = indiceCombo;
                    break;
                }
            }

            MostrarPermisos();
        }
        private void ConfigurarAgregar()
        {
            this.Text = "Agregar Grupo";
            lbltitulo.Text = "Agregar Grupo";
            btnguardarpermiso.Text = "Guardar";
            txtnombregrupo.ReadOnly = false;
        }
        private void ConfigurarEditar()
        {
            this.Text = "Editar Grupo";
            lbltitulo.Text = "Editar Grupo";
            btnguardarpermiso.Text = "Editar";
            txtnombregrupo.ReadOnly = false;

            txtnombregrupo.Text = _oGrupoPermiso.Nombre.ToString();

            foreach (OpcionCombo opcion in cbestado.Items)
            {
                if (Convert.ToInt32(opcion.Valor) == (_oGrupoPermiso.Estado == true ? 1 : 0))
                {
                    int indiceCombo = cbestado.Items.IndexOf(opcion);
                    cbestado.SelectedIndex = indiceCombo;
                    break;
                }
            }

            MostrarPermisos();
        }
        private void MostrarPermisos()
        {
            //MOSTRAR LOS PERMISOS
            List<Componente> listaComponentes = objcn_GrupoPermiso.ListarComponentes(_idGrupoPermiso);

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
        private void AgregarGrupo()
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

            GrupoPermiso oGrupoPermiso = new GrupoPermiso()
            {
                NombreGrupo = txtnombregrupo.Text,
                Estado = Convert.ToBoolean(((OpcionCombo)cbestado.SelectedItem).Valor)
            };

            bool resultado = objcn_GrupoPermiso.RegistrarGrupoPermiso(oGrupoPermiso, listaComponentes, out string mensaje);

            if (resultado)
            {
                MessageBox.Show("Grupo registrado correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void EditarGrupo()
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

            GrupoPermiso oGrupoPermiso = new GrupoPermiso()
            {
                IdGrupoPermiso = _idGrupoPermiso,
                IdComponente = _oGrupoPermiso.IdComponente,
                NombreGrupo = txtnombregrupo.Text.Trim(),
                Estado = Convert.ToBoolean(((OpcionCombo)cbestado.SelectedItem).Valor)
            };

            bool resultado = objcn_GrupoPermiso.EditarGrupoPermiso(oGrupoPermiso, listaComponentes, out string mensaje);

            if (resultado)
            {
                MessageBox.Show("Grupo editado correctamente.\nSe recomienda reiniciar el sistema", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnagregarpermiso_Click(object sender, EventArgs e)
        {
            using (var modal = new MD_AgregarComponenteAGrupo())
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
        }

        private void btneliminarpermiso_Click(object sender, EventArgs e)
        {
            int indice = dgvdata.CurrentRow.Index;

            if (indice >= 0)
            {
                dgvdata.Rows.RemoveAt(indice);
            }

            dgvdata.ClearSelection();
            txtid.Text = "";
        }

        private void btnguardarpermiso_Click(object sender, EventArgs e)
        {
            if (txtnombregrupo.Text == "")
            {
                MessageBox.Show("Debe completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            switch (_tipoModal)
            {
                case "Agregar":
                    AgregarGrupo();
                    break;
                case "Editar":
                    EditarGrupo();
                    break;
            }
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
    }
}
