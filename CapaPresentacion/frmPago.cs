using CapaDatos;
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
    public partial class frmPago : Form
    {
        private Usuario _usuarioActual;

        //Nueva instancia
        CD_Pago cdP = new CD_Pago();
        private string id = null;
        private bool editar = false;

        public frmPago()
        {
            InitializeComponent();
        }

        private void frmPago_Load(object sender, EventArgs e)
        {

            MostrarDatos();
            MostrarCuotas();
            MostrarSocios();
            txtfecha.Text = DateTime.Now.ToString("dd-MM-yyyy");
            /*
            //MOSTRAR LOS BOTONES SEGUN EL PERMISO
            List<Permiso> listaPermisos = _usuarioActual.GetPermisos();
            List<Button> listaBotones = new List<Button> { btnguardarpago, btneliminarpago };

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
            }*/
        }

        public void MostrarDatos()
        {
            CD_Pago obj = new CD_Pago();
            dgvdata.DataSource = obj.mostrar();
        }
        public void MostrarCuotas()
        {
            CD_Pago obj = new CD_Pago();
            cbcuota.DataSource = obj.llenar_cuotas();
            cbcuota.DisplayMember = "mes_cuota";
            cbcuota.ValueMember = "cod_cuota";
        }
        public void MostrarSocios()
        {
            CD_Pago obj = new CD_Pago();
            cbcliente.DataSource = obj.llenar_socios();
            cbcliente.DisplayMember = "Documento";
            cbcliente.ValueMember = "IdCliente";
        }

        private void btnguardarproducto_Click(object sender, EventArgs e)
        {
            if (editar == false)
            {
                try
                {
                    cdP.Insert(Convert.ToInt32(cbcliente.SelectedValue), Convert.ToInt32(cbcuota.SelectedValue), Convert.ToDateTime(txtfecha.Text));
                    MessageBox.Show("Se agrego Pago con exito!");
                    MostrarDatos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al ingresar datos!" + ex);
                }
            }
            if (editar == true)
            {
                try
                {
                    cdP.Update(Convert.ToInt32(id), Convert.ToInt32(cbcliente.SelectedValue), Convert.ToInt32(cbcuota.SelectedValue), Convert.ToDateTime(txtfecha.Text));
                    MessageBox.Show("Datos modificados con exito!");
                    MostrarDatos();
                    editar = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al ingresar datos!" + ex);
                }
            }
        }

        private void btneliminarproducto_Click(object sender, EventArgs e)
        {
            if (dgvdata.SelectedRows.Count > 0)
            {
                id = dgvdata.CurrentRow.Cells["PAGO"].Value.ToString();
                cdP.Delete(Convert.ToInt32(id));
                MessageBox.Show("El Pago se ha eliminado correctamente!");
                MostrarDatos();
            }
            else
            {
                MessageBox.Show("Error al eliminar los datos!");
            }
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            txtcodigo.Clear();
            txtfecha.Clear();
            txtprecio.Clear();
        }
    }
}
