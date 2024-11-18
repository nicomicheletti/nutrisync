using CapaEntidad;
using CapaPresentacion;
using CapaNegocio;
using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaPresentacion.Modales;
using CapaDatos;

namespace CapaPresentación
{
    public partial class Inicio : Form
    {
        private static Usuario usuarioActual;
        private static IconMenuItem MenuActivo = null;
        private static Form FormularioActivo = null;

        public Inicio(Usuario objusuario)
        {
            usuarioActual = objusuario;
            usuarioActual.SetPermisos(new CN_Permiso().Listar(usuarioActual.IdUsuario));

            InitializeComponent();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            List<Permiso> listaPermisos = usuarioActual.GetPermisos();

            foreach (IconMenuItem iconmenu in menu.Items)
            {
                try
                {
                    bool encontrado = listaPermisos.Any(p => p.NombreMenu == iconmenu.Name);

                    if (encontrado)
                    {
                        iconmenu.Visible = true;
                    }
                    else
                    {
                        iconmenu.Visible = false;
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }

            foreach (ToolStripMenuItem menu in menuseguridad.DropDownItems)
            {
                bool encontrado = listaPermisos.Any(p => p.NombreMenu == menu.Name);

                if (encontrado)
                {
                    menu.Visible = true;
                }
                else
                {
                    menu.Visible = false;
                }
            }

            foreach (ToolStripMenuItem menu in menuventas.DropDownItems)
            {
                bool encontrado = listaPermisos.Any(p => p.NombreMenu == menu.Name);

                if (encontrado)
                {
                    menu.Visible = true;
                }
                else
                {
                    menu.Visible = false;
                }
            }

            foreach (ToolStripMenuItem menu in menucompras.DropDownItems)
            {
                bool encontrado = listaPermisos.Any(p => p.NombreMenu == menu.Name);

                if (encontrado)
                {
                    menu.Visible = true;
                }
                else
                {
                    menu.Visible = false;
                }
            }


            foreach (ToolStripMenuItem menu in menureportes.DropDownItems)
            {
                bool encontrado = listaPermisos.Any(p => p.NombreMenu == menu.Name);

                if (encontrado)
                {
                    menu.Visible = true;
                }
                else
                {
                    menu.Visible = false;
                }
            }

            lblUsuario.Text = "Usuario: " + usuarioActual.NombreCompleto;
        }


        private void AbrirFormulario(IconMenuItem menu, Form formulario)
        {
            if (MenuActivo != null)
            {
                MenuActivo.BackColor = Color.White;
            }
            MenuActivo = menu;
            menu.BackColor = Color.Silver;

            if (FormularioActivo != null)
            {
                FormularioActivo.Close();
            }
            FormularioActivo = formulario;
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            formulario.BackColor = Color.White;
            contenedor.Controls.Add(formulario);
            formulario.Show();
        }

        private void submenuusuario_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menuseguridad, new frmSeguridad(usuarioActual));
        }

        private void submenuClientes_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menuventas, new frmCliente(usuarioActual));
        }

        private void submenuVentas_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menuventas, new frmVentas(usuarioActual));
        }

        private void submenuCategoria_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menucompras, new frmCategoria(usuarioActual));
        }

        private void submenuCompras_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menucompras, new frmCompras(usuarioActual));
        }

        private void submenunegocio_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menucompras, new frmNegocio());
        }

        private void submenuProducto_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menucompras, new frmProducto(usuarioActual));
        }

        private void submenuProveedores_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menucompras, new frmProveedor(usuarioActual));
        }

        private void submenureportecompras_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menureportes, new frmReporteCompras());
        }

        private void submenureporteventas_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menureportes, new frmReporteVentas());
        }

        private void menuacercade_Click(object sender, EventArgs e)
        {
            MD_AcercaDe md = new MD_AcercaDe();
            md.ShowDialog();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea Salir?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void submenupermiso_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menuseguridad, new frmPermiso(usuarioActual));
        }

        private void submenugrupo_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menuseguridad, new frmGrupo(usuarioActual));
        }

        private void submenuhistorialcompras_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menucompras, new frmHistorialCompras());
        }

        private void submenuhistorialventas_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menuventas, new frmHistorialVentas());
        }

        private void submenuauditoria_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menuventas, new frmAuditoriaVentas());
        }

        private void menubackup_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menubackup, new frmBackUp());
        }

        private void cuotaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menumembresia, new frmCuota());
        }

        private void submenupago_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menumembresia, new frmPago());
        }
    }
}
