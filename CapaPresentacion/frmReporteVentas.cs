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
    public partial class frmReporteVentas : Form
    {

        public frmReporteVentas()
        {
            InitializeComponent();
        }

        private void frmReporteVentas_Load(object sender, EventArgs e)
        {
            foreach (DataGridViewColumn columna in dgvdata.Columns)
            {
                cbbuscarpor.Items.Add(new OpcionCombo() { Valor = columna.Name, Texto = columna.HeaderText });
            }
            cbbuscarpor.DisplayMember = "Texto";
            cbbuscarpor.ValueMember = "Valor";
            cbbuscarpor.SelectedIndex = 0;
        }


        private void btnbuscarpor_Click(object sender, EventArgs e)
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

        private void iconButton1_Click(object sender, EventArgs e)
        {
            txtbuscarpor.Text = "";
            foreach (DataGridViewRow row in dgvdata.Rows)
            {
                row.Visible = true;
            }
        }

        private void btnbuscarreporte_Click(object sender, EventArgs e)
        {
            Dictionary<string, int> ventasPorCliente = new Dictionary<string, int>();

            List<ReporteVenta> lista = new List<ReporteVenta>();

            lista = new CN_Reporte().Venta(
            dtpfechainicio.Value.ToString(),
            dtpfechafin.Value.ToString());

            dgvdata.Rows.Clear();

            int totalVentas = ventasPorCliente.Sum(x => x.Value);

            foreach (ReporteVenta rv in lista)
            {
                string nombreCliente = rv.NombreCliente;
                if (ventasPorCliente.ContainsKey(nombreCliente))
                {
                    int cantidad = int.Parse(rv.Cantidad); // Convertir rv.Cantidad a entero
                    ventasPorCliente[nombreCliente] += cantidad; // Sumar la cantidad convertida
                }
                else
                {
                    int cantidad = int.Parse(rv.Cantidad); // Convertir rv.Cantidad a entero
                    ventasPorCliente.Add(nombreCliente, cantidad); // Agregar la cantidad convertida
                }

                dgvdata.Rows.Add(new object[]
                {
                    rv.FechaRegistro,
                    rv.TipoDocumento,
                    rv.NumeroDocumento,
                    rv.MontoTotal,
                    rv.UsuarioRegistro,
                    rv.DocumentoCliente,
                    rv.NombreCliente,
                    rv.CodigoProducto,
                    rv.NombreProducto,
                    rv.Categoria,
                    rv.PrecioVenta,
                    rv.Cantidad,
                    rv.SubTotal
                });
            }
            // Verificar si la serie ya existe
            var series = graficoventas.Series.FindByName("Ventas por Cliente");

            // Si la serie no existe, agregarla al gráfico
            if (series == null)
            {
                series = graficoventas.Series.Add("Ventas por Cliente");
                series.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            }

            graficoventas.Series[1].Points.Clear();

            foreach (var kvp in ventasPorCliente)
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
            graficoventas.Series[1]["PieDrawingStyle"] = "SoftEdge";
            graficoventas.Series[1]["PieLabelStyle"] = "Inside";
            graficoventas.Series[1]["PieStartAngle"] = "90";

            // Ajustar la alineación del gráfico de pastel
            graficoventas.Series[1]["PieLabelStyle"] = "Inside"; // Colocar las etiquetas dentro del área del gráfico
            graficoventas.Series[1]["SmartLabelStyle"] = "Enabled"; // Habilitar el ajuste automático de las etiquetas

            graficoventas.Series[1]["AlignmentOrientation"] = "AllAxes"; // Alinear el gráfico de pastel en el centro
            graficoventas.Series[1]["AlignmentStyle"] = "Center";

            graficoventas.Legends[0].Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            graficoventas.Legends[0].Enabled = true;
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
                            row.Cells[12].Value.ToString()
                        }
                    );
                }

                SaveFileDialog savefile = new SaveFileDialog();
                savefile.FileName = string.Format("ReporteVentas_{0}.xlsx", DateTime.Now.ToString("ddMMyyyyHHmmss"));
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
