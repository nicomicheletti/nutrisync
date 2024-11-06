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
    public partial class frmDetalleCompra : Form
    {
        private int numero_documento;
        public frmDetalleCompra(int numero)
        {
            numero_documento = numero;
            InitializeComponent();
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            Compra oCompra = new CN_Compra().ObtenerCompra(txtnumerodocumento.Text);

            if (oCompra.IdCompra != 0)
            {
                txtnumdoc.Text = oCompra.NumeroDocumento;
                txtfecha.Text = oCompra.FechaRegistro;
                txttipodocumento.Text = oCompra.TipoDocumento;
                txtusuario.Text = oCompra.OUsuario.NombreCompleto;
                txtdocproveedor.Text = oCompra.OProveedor.Documento;
                txtrazonsocial.Text = oCompra.OProveedor.RazonSocial;

                dgvproducto.Rows.Clear();
                foreach (Detalle_Compra dc in oCompra.ODetalleCompra)
                {
                    dgvproducto.Rows.Add(new object[]
                    {
                        dc.OProducto.Nombre,
                        dc.PrecioCompra,
                        dc.Cantidad,
                        dc.MontoTotal
                    });
                }
                txtmontototal.Text = oCompra.MontoTotal.ToString("0.00");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            txtfecha.Text = "";
            txttipodocumento.Text = "";
            txtusuario.Text = "";
            txtdocproveedor.Text = "";
            txtrazonsocial.Text = "";

            dgvproducto.Rows.Clear();
            txtmontototal.Text = "0.00";
        }

        private void txtbusqueda_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Esto indica que el evento ha sido manejado y el carácter no será procesado
            }
            else
            {
                e.Handled = false;
            }
        }

        private void frmDetalleCompra_Load(object sender, EventArgs e)
        {
            txtnumerodocumento.Text = "0000" + numero_documento.ToString();

            Compra oCompra = new CN_Compra().ObtenerCompra(txtnumerodocumento.Text);

            if (oCompra.IdCompra != 0)
            {
                txtnumdoc.Text = oCompra.NumeroDocumento;
                txtfecha.Text = oCompra.FechaRegistro;
                txttipodocumento.Text = oCompra.TipoDocumento;
                txtusuario.Text = oCompra.OUsuario.NombreCompleto;
                txtdocproveedor.Text = oCompra.OProveedor.Documento;
                txtrazonsocial.Text = oCompra.OProveedor.RazonSocial;

                dgvproducto.Rows.Clear();
                foreach (Detalle_Compra dc in oCompra.ODetalleCompra)
                {
                    dgvproducto.Rows.Add(new object[]
                    {
                        dc.OProducto.Nombre,
                        dc.PrecioCompra,
                        dc.Cantidad,
                        dc.MontoTotal
                    });
                }
                txtmontototal.Text = oCompra.MontoTotal.ToString("0.00");
            }
        }
    }
}
