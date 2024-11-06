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
    public partial class frmAuditoriaVentas : Form
    {
        public frmAuditoriaVentas()
        {
            InitializeComponent();
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            txtindice.Text = "-1";
            txtfechaauditoria.Text = "";
            txtoperacion.Text = "";
            txtmontototal.Text = "";
            txttipodocumento.Text = "";
            txtnrodocumento.Text = "";
            txtnombrecliente.Text = "";
            txtnombreusuario.Text = "";

            txtoperacion.Select();
        }

        private void frmAuditoriaVentas_Load(object sender, EventArgs e)
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

            //MOSTRAR TODAS LAS AUDITORIAS
            List<AuditoriaVenta> lista = new CN_Venta().ListarAuditoria();

            foreach (AuditoriaVenta item in lista)
            {
                dgvdata.Rows.Add(new object[] {"", item.FechaAuditoria, item.Operacion, item.OVenta.TipoDocumento, item.OVenta.NumeroDocumento,
                item.OVenta.NombreCliente, item.OVenta.MontoTotal,
                item.OUsuario.NombreCompleto});
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
            if (dgvdata.Columns[e.ColumnIndex].Name == "btnSeleccionar")
            {
                int indice = e.RowIndex;

                if (indice >= 0)
                {
                    txtindice.Text = indice.ToString();

                    txtfechaauditoria.Text = dgvdata.Rows[indice].Cells["FechaAuditoria"].Value.ToString();
                    txtoperacion.Text = dgvdata.Rows[indice].Cells["Operacion"].Value.ToString();
                    txtmontototal.Text = dgvdata.Rows[indice].Cells["MontoTotal"].Value.ToString();
                    txttipodocumento.Text = dgvdata.Rows[indice].Cells["TipoDocumento"].Value.ToString();
                    txtnrodocumento.Text = dgvdata.Rows[indice].Cells["NumeroDocumento"].Value.ToString();
                    txtnombrecliente.Text = dgvdata.Rows[indice].Cells["NombreCliente"].Value.ToString();
                    txtnombreusuario.Text = dgvdata.Rows[indice].Cells["NombreCompleto"].Value.ToString();
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
    }
}
