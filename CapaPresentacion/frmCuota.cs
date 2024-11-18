using CapaDatos;
using CapaEntidad;
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
    public partial class frmCuota : Form
    {

        private Usuario _usuarioActual;

        //Nueva instancia
        CD_Cuota cdC = new CD_Cuota();
        private string id = null;
        private bool editar = false;

        public frmCuota()
        {
            InitializeComponent();
        }

        private void frmCuota_Load(object sender, EventArgs e)
        {
            MostrarDatos();
            /*
            //MOSTRAR LOS BOTONES SEGUN EL PERMISO
            List<Permiso> listaPermisos = _usuarioActual.GetPermisos();
            List<Button> listaBotones = new List<Button> { btnguardarcuota, btneliminarcuota };

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
            CD_Cuota obj = new CD_Cuota();
            dgvdata.DataSource = obj.mostrar();
        }

        private void btnguardarproducto_Click(object sender, EventArgs e)
        {
            if (editar == false)
            {
                try
                {
                    cdC.Insert(Convert.ToInt32(txtcodigo.Text), txtmes.Text, txtanio.Text, Convert.ToInt32(txtprecio.Text));
                    MessageBox.Show("Se agrego Cuota con exito!");
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
                    cdC.Update(Convert.ToInt32(id), txtmes.Text, txtanio.Text, Convert.ToInt32(txtprecio.Text));
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
                id = dgvdata.CurrentRow.Cells["CODIGO"].Value.ToString();
                cdC.Delete(Convert.ToInt32(id));
                MessageBox.Show("La Cuota se ha eliminado correctamente!");
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
            txtmes.Clear();
            txtanio.Clear();
            txtprecio.Clear();
        }
    }
}
