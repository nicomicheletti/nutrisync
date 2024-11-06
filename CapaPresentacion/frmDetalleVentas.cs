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

namespace CapaPresentacion
{
    public partial class frmDetalleVentas : Form
    {
        private int numero_documento;
        public frmDetalleVentas(int numero)
        {
            numero_documento = numero;
            InitializeComponent();
        }

        private void frmDetalleVentas_Load(object sender, EventArgs e)
        {
            txtnumerodocumento.Text = "0000" + numero_documento.ToString();

            Venta oVenta = new CN_Venta().ObtenerVenta(txtnumerodocumento.Text);

            if (oVenta.IdVenta != 0)
            {
                txtnumdoc.Text = oVenta.NumeroDocumento;

                txtfecha.Text = oVenta.FechaRegistro;
                txttipodocumento.Text = oVenta.TipoDocumento;
                txtusuario.Text = oVenta.OUsuario.NombreCompleto;

                txtdoccliente.Text = oVenta.DocumentoCliente;
                txtnombrecliente.Text = oVenta.NombreCliente;

                dgvproducto.Rows.Clear();

                foreach (Detalle_Venta dv in oVenta.ODetalleVenta)
                {
                    dgvproducto.Rows.Add(new object[]
                    {
                        dv.OProducto.Nombre, dv.PrecioVenta, dv.Cantidad, dv.SubTotal
                    });
                }

                txtmontototal.Text = oVenta.MontoTotal.ToString("0.00");
                txtpago.Text = oVenta.MontoPago.ToString("0.00");
                txtcambio.Text = oVenta.MontoCambio.ToString("0.00");
            }
        }
    }
}
