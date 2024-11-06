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
    public partial class MD_DetallePermisoSimple : Form
    {
        private int _idPermiso;
        private CN_Permiso objcn_Permiso = new CN_Permiso();
        private Permiso oPermiso = new Permiso();
        public MD_DetallePermisoSimple(int idPermiso)
        {
            _idPermiso = idPermiso;
            oPermiso = objcn_Permiso.ListarPermisos().Where(p => p.IdPermiso == _idPermiso).FirstOrDefault();
            InitializeComponent();
        }

        private void MD_DetallePermisoSimple_Load(object sender, EventArgs e)
        {
            txtnombremenu.Text = oPermiso.NombreMenu;
            txtnombrepermiso.Text = oPermiso.Nombre;

            cbestado.Items.Add(new OpcionCombo() { Valor = 1, Texto = "Activo" });
            cbestado.Items.Add(new OpcionCombo() { Valor = 0, Texto = "No Activo" });
            cbestado.SelectedIndex = 0;
            cbestado.DisplayMember = "Texto";
            cbestado.ValueMember = "Valor";
        }
    }
}
