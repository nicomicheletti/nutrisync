using CapaEntidad;
using CapaNegocio;
using CapaPresentacion.Modales;
using CapaPresentacion.Utilidades;
using DocumentFormat.OpenXml.Wordprocessing;
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
    public partial class frmHistorialCompras : Form
    {
        public frmHistorialCompras()
        {
            InitializeComponent();
        }

        private void frmHistorialCompras_Load(object sender, EventArgs e)
        {
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

            //MOSTRAR TODAS LAS COMPRAS
            List<Compra> lista = new CN_Compra().Listar();

            foreach (Compra item in lista)
            {
                dgvdata.Rows.Add(new object[] {"", item.TipoDocumento, item.NumeroDocumento,
                item.MontoTotal });
            }
        }

        private void btnverdetallecompra_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtnumerodocumento.Text.Trim() != "")
                {
                    using (var modal = new frmDetalleCompra(Convert.ToInt32(txtnumerodocumento.Text)))
                    {
                        var result = modal.ShowDialog();
                    }
                }
                else
                {
                    MessageBox.Show("Debe seleccionar una compra", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
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
            if (dgvdata.Columns[e.ColumnIndex].Name == "btnseleccionar")
            {
                int indice = e.RowIndex;

                if (indice >= 0)
                {
                    txtnumerodocumento.Text = dgvdata.Rows[indice].Cells["NumeroDocumento"].Value.ToString();
                }
            }
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

        private void dgvdata_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnverdetallecompra_Click(null, null);
        }
    }
}
