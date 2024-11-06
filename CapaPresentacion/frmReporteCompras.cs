using CapaEntidad;
using CapaNegocio;
using CapaPresentacion.Utilidades;
using ClosedXML.Excel;
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
    public partial class frmReporteCompras : Form
    {
        public frmReporteCompras()
        {
            InitializeComponent();
        }

        private void frmReporteCompras_Load(object sender, EventArgs e)
        {
            List<Proveedor> lista = new CN_Proveedor().Listar();

            cbproveedor.Items.Add(new OpcionCombo() { Valor = 0, Texto = "TODOS" });
            foreach (Proveedor item in lista)
            {
                cbproveedor.Items.Add(new OpcionCombo() { Valor = item.IdProveedor, Texto = item.RazonSocial });
            }
            cbproveedor.DisplayMember = "Texto";
            cbproveedor.ValueMember = "Value";
            cbproveedor.SelectedIndex = 0;

            foreach (DataGridViewColumn columna in dgvdata.Columns)
            {
                cbbuscarpor.Items.Add(new OpcionCombo() { Valor = columna.Name, Texto = columna.HeaderText });
            }
            cbbuscarpor.DisplayMember = "Texto";
            cbbuscarpor.ValueMember = "Valor";
            cbbuscarpor.SelectedIndex = 0;
        }

        private void btnbuscarreporte_Click(object sender, EventArgs e)
        {
            Dictionary<string, int> comprasPorCliente = new Dictionary<string, int>();

            int idproveedor = Convert.ToInt32(((OpcionCombo)cbproveedor.SelectedItem).Valor.ToString());

            List<ReporteCompra> lista = new List<ReporteCompra>();

            lista = new CN_Reporte().Compra(
                dtpfechainicio.Value.ToString(),
                dtpfechafin.Value.ToString(),
                idproveedor);

            dgvdata.Rows.Clear();

            int totalVentas = comprasPorCliente.Sum(x => x.Value);

            foreach (ReporteCompra rc in lista)
            {
                string nombreCliente = rc.NombreProducto;
                if (comprasPorCliente.ContainsKey(nombreCliente))
                {
                    int cantidad = int.Parse(rc.Cantidad); // Convertir rv.Cantidad a entero
                    comprasPorCliente[nombreCliente] += cantidad; // Sumar la cantidad convertida
                }
                else
                {
                    int cantidad = int.Parse(rc.Cantidad); // Convertir rv.Cantidad a entero
                    comprasPorCliente.Add(nombreCliente, cantidad); // Agregar la cantidad convertida
                }

                dgvdata.Rows.Add(new object[]
                {
                    rc.FechaRegistro,
                    rc.TipoDocumento,
                    rc.NumeroDocumento,
                    rc.MontoTotal,
                    rc.UsuarioRegistro,
                    rc.DocumentoProveedor,
                    rc.RazonSocial,
                    rc.CodigoProducto,
                    rc.NombreProducto,
                    rc.Categoria,
                    rc.PrecioCompra,
                    rc.PrecioVenta,
                    rc.Cantidad,
                    rc.SubTotal
                });
            }
            // Verificar si la serie ya existe
            var series = graficocompras.Series.FindByName("Ventas por Cliente");

            // Si la serie no existe, agregarla al gráfico
            if (series == null)
            {
                series = graficocompras.Series.Add("Ventas por Cliente");
                series.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            }

            graficocompras.Series[1].Points.Clear();

            foreach (var kvp in comprasPorCliente)
            {
                double porcentaje = (double)kvp.Value / totalVentas * 100;

                // Agregar el punto de datos
                var point = series.Points.Add(kvp.Value);

                // Establecer el nombre del cliente como texto de leyenda del punto
                point.LegendText = kvp.Key;

                // Mostrar el porcentaje como etiqueta en formato de porcentaje con dos decimales
                point.Label = "#PERCENT{P2}";

                // Mostrar los valores como etiquetas en las porciones del gráfico
                point.IsValueShownAsLabel = true;

            }
            graficocompras.Series[1]["PieDrawingStyle"] = "SoftEdge";
            graficocompras.Series[1]["PieLabelStyle"] = "Inside";
            graficocompras.Series[1]["PieStartAngle"] = "90";

            // Ajustar la alineación del gráfico de pastel
            graficocompras.Series[1]["PieLabelStyle"] = "Inside"; // Colocar las etiquetas dentro del área del gráfico
            graficocompras.Series[1]["SmartLabelStyle"] = "Enabled"; // Habilitar el ajuste automático de las etiquetas

            graficocompras.Series[1]["AlignmentOrientation"] = "AllAxes"; // Alinear el gráfico de pastel en el centro
            graficocompras.Series[1]["AlignmentStyle"] = "Center";

            graficocompras.Legends[0].Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            graficocompras.Legends[0].Enabled = true;
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            txtbuscarpor.Text = "";
            foreach (DataGridViewRow row in dgvdata.Rows)
            {
                row.Visible = true;
            }
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            string columnafiltro = ((OpcionCombo)cbbuscarpor.SelectedItem).Valor.ToString();

            if (dgvdata.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvdata.Rows)
                {
                    if (row.Cells[columnafiltro].Value.ToString().Trim().ToUpper().Contains(txtbuscarpor.Text.Trim().ToUpper()))
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

        private void btndescarcar_Click(object sender, EventArgs e)
        {
            if (dgvdata.Rows.Count < 1)
            {
                MessageBox.Show("No hay registros para exportar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                DataTable dt = new DataTable();

                foreach (DataGridViewColumn columna in dgvdata.Columns)
                {
                    dt.Columns.Add(columna.HeaderText, typeof(string));
                }

                foreach (DataGridViewRow row in dgvdata.Rows)
                {
                    if (row.Visible)
                        dt.Rows.Add(new object[] {
                            row.Cells[0].Value.ToString(),
                            row.Cells[1].Value.ToString(),
                            row.Cells[2].Value.ToString(),
                            row.Cells[3].Value.ToString(),
                            row.Cells[4].Value.ToString(),
                            row.Cells[5].Value.ToString(),
                            row.Cells[6].Value.ToString(),
                            row.Cells[7].Value.ToString(),
                            row.Cells[8].Value.ToString(),
                            row.Cells[9].Value.ToString(),
                            row.Cells[10].Value.ToString(),
                            row.Cells[11].Value.ToString(),
                            row.Cells[12].Value.ToString(),
                            row.Cells[13].Value.ToString()
                        }
                    );
                }

                SaveFileDialog savefile = new SaveFileDialog();
                savefile.FileName = string.Format("ReporteCompras_{0}.xlsx", DateTime.Now.ToString("ddMMyyyyHHmmss"));
                savefile.Filter = "Excel Files | *.xlsx";

                if (savefile.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        ClosedXML.Excel.XLWorkbook wb = new ClosedXML.Excel.XLWorkbook();
                        var hoja = wb.Worksheets.Add(dt, "Informe");
                        hoja.ColumnsUsed().AdjustToContents();
                        wb.SaveAs(savefile.FileName);
                        MessageBox.Show("Reporte Generado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch
                    {
                        MessageBox.Show("Error al generar reporte", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
        }
    }
}
