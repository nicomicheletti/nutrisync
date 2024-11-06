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
    public partial class MD_AgregarComponenteAGrupo : Form
    {
        private CN_GrupoPermiso objcn_GrupoPermiso = new CN_GrupoPermiso();
        public Componente oComponente { get; set; }
        public MD_AgregarComponenteAGrupo()
        {
            InitializeComponent();
        }

        private void MD_AgregarComponenteAGrupo_Load(object sender, EventArgs e)
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

            dgvdata.Rows.Clear();

            //MOSTRAR LOS COMPONENTES
            List<Componente> listaComponentes = objcn_GrupoPermiso.ListarComponentes(0);

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

            txtid.Text = "";

            txtbusqueda.Select();
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
                txtid.Text = dgvdata.Rows[indice].Cells["IdComponente"].Value.ToString();
            }
        }

        private void dgvdata_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int indiceFila = e.RowIndex;
            int indiceColumna = e.ColumnIndex;

            if (indiceFila >= 0 && indiceColumna >= 0)
            {
                oComponente = new Componente();
                oComponente.IdComponente = Convert.ToInt32(dgvdata.Rows[indiceFila].Cells["IdComponente"].Value.ToString());
                oComponente.Nombre = dgvdata.Rows[indiceFila].Cells["Nombre"].Value.ToString();
                oComponente.TipoComponente = dgvdata.Rows[indiceFila].Cells["TipoPermiso"].Value.ToString();
                oComponente.Estado = Convert.ToInt32(dgvdata.Rows[indiceFila].Cells["Estado"].Value.ToString()) == 1 ? true : false;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
