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
    public class CN_GrupoPermiso
    {
        CD_GrupoPermiso objcd_GrupoPermiso = new CD_GrupoPermiso();
        public List<GrupoPermiso> ListarGrupoPermisos()
        {
            try
            {
                return objcd_GrupoPermiso.ListarGrupoPermisos();
            }
            catch (Exception ex) 
            { 
                throw new Exception(ex.Message);
            }
        }
        public List<Componente> ListarComponentes(int idGrupoPermiso)
        {
            try
            {
                return objcd_GrupoPermiso.ListarComponente(idGrupoPermiso);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public bool RegistrarGrupoPermiso(GrupoPermiso oGrupoPermiso, DataTable listaComponentes, out string mensaje)
        {
            try
            {
                return objcd_GrupoPermiso.RegistrarGrupoPermiso(oGrupoPermiso, listaComponentes, out mensaje);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public bool EditarGrupoPermiso(GrupoPermiso oGrupoPermiso, DataTable listaComponentes, out string mensaje)
        {
            try
            {
                return objcd_GrupoPermiso.EditarGrupoPermiso(oGrupoPermiso, listaComponentes, out mensaje);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public bool EliminarGrupoPermiso(GrupoPermiso oGrupoPermiso, out string mensaje)
        {
            try
            {
                return objcd_GrupoPermiso.EliminarGrupoPermiso(oGrupoPermiso, out mensaje);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
