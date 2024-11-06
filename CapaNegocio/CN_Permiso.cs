using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Permiso
    {
        private CD_Permiso objcd_permiso = new CD_Permiso();

        public List<Permiso> Listar(int idUsuario)
        {
            try
            {
                return objcd_permiso.Listar(idUsuario);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public List<Permiso> ListarPermisos()
        {
            try
            {
                return objcd_permiso.ListarPermisos();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public bool EditarEstado(int idComponente, bool estado, out string mensaje)
        {
            try
            {
                return objcd_permiso.EditarEstado(idComponente, estado, out mensaje);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
