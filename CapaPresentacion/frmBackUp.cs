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
    public partial class frmBackUp : Form
    {
        public frmBackUp()
        {
            InitializeComponent();
        }

        private void btnresguardar_Click(object sender, EventArgs e)
        {
            string Mensaje = string.Empty;
            try
            {
                bool obj = new CN_ResguardoRestauracion().Resguardo(out Mensaje);
                if (obj)
                {
                    MessageBox.Show("Se ha realizado el resguardo con éxito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se ha podido realizar el resguardo.\n\nPor favor intente de nuevo.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnrestaurar_Click(object sender, EventArgs e)
        {
            string Mensaje = string.Empty;
            try
            {
                DialogResult resultado = MessageBox.Show("Desea realizar la restauracion del sistema?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(resultado == DialogResult.Yes)
                {
                    bool obj = new CN_ResguardoRestauracion().Restauracion(out Mensaje);
                    if (obj)
                    {
                        MessageBox.Show("Se ha realizado la restauración con éxito\n\nPor favor, reiniciar el sistema", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se ha podido realizar la restauración.\n\nPor favor intente de nuevo.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
