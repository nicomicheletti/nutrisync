using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_UsuarioPermiso
    {
        private CD_UsuarioPermiso objcd_usuariopermiso = new CD_UsuarioPermiso();
        public List<Componente> ListarComponente(int idUsuario)
        {
            try
            {
                return objcd_usuariopermiso.ListarComponentesPorId(idUsuario);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public bool EditrarUsuarioPermiso(int idUsuario, DataTable listaComponentes, out string mensaje)
        {
            try
            {
                return objcd_usuariopermiso.EditarUsuarioPermiso(idUsuario, listaComponentes, out mensaje);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
