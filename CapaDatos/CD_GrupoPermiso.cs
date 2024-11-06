using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_GrupoPermiso
    {
        public List<GrupoPermiso> ListarGrupoPermisos()
        {
            List<GrupoPermiso> listagp = new List<GrupoPermiso>();

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select c.IdComponente, c.Nombre, c.Estado,");
                    query.AppendLine("gp.IdGrupoPermiso ");
                    query.AppendLine("from COMPONENTE c");
                    query.AppendLine("inner join GRUPO_PERMISO gp on c.IdComponente = gp.IdComponente");

                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.CommandType = CommandType.Text;

                    oconexion.Open();

                    SqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        GrupoPermiso grupoPermiso = new GrupoPermiso();
                        grupoPermiso.IdGrupoPermiso = Convert.ToInt32(dr["IdGrupoPermiso"]);
                        grupoPermiso.IdComponente = Convert.ToInt32(dr["IdComponente"]);
                        grupoPermiso.Nombre = dr["Nombre"].ToString();
                        grupoPermiso.Estado = Convert.ToBoolean(dr["Estado"]);
                        grupoPermiso.NombreGrupo = dr["Nombre"].ToString();

                        listagp.Add(grupoPermiso);
                    }
                }
                catch (Exception ex)
                { 
                    listagp = new List<GrupoPermiso>();
                }
            }
            return listagp;
        }

        public List<Componente> ListarComponente(int idGrupoPermiso)
        {
            List<Componente> listac = new List<Componente>();

            using(SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    if (idGrupoPermiso != 0)
                    {
                        query.AppendLine("select c.Nombre, c.TipoComponente, c.Estado, c.IdComponente ");
                        query.AppendLine("from GRUPO_PERMISO_COMPONENTE gpc ");
                        query.AppendLine("inner join GRUPO_PERMISO gp on gpc.IdGrupoPermiso = gp.IdGrupoPermiso ");
                        query.AppendLine("inner join COMPONENTE c on gpc.IdComponente = c.IdComponente ");
                        query.AppendLine("where gpc.IdGrupoPermiso = @IdGrupoPermiso");
                    }
                    else
                    {
                        query.AppendLine("select IdComponente, Nombre, TipoComponente, Estado ");
                        query.AppendLine("from COMPONENTE");
                    }
                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    if (idGrupoPermiso != 0)
                    {
                        cmd.Parameters.AddWithValue("@IdGrupoPermiso", idGrupoPermiso);
                    }

                    cmd.CommandType = CommandType.Text;

                    oconexion.Open();

                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        Componente componente = new Componente();
                        componente.IdComponente = Convert.ToInt32(dr["IdComponente"]);
                        componente.Nombre = dr["Nombre"].ToString();
                        componente.Estado = Convert.ToBoolean(dr["Estado"]);
                        componente.TipoComponente = dr["TipoComponente"].ToString();

                        listac.Add(componente);
                    }
                }
                catch (Exception ex)
                {
                    listac = new List<Componente>();
                }
            }
            return listac;
        }
        public bool RegistrarGrupoPermiso(GrupoPermiso oGrupoPermiso, DataTable listaComponentes, out string mensaje)
        {
            bool resultado = false;
            mensaje = string.Empty;

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("SP_RegistrarGrupoPermiso", oconexion);

                    //Parametros de Entrada
                    cmd.Parameters.AddWithValue("NombreGrupo", oGrupoPermiso.NombreGrupo);
                    cmd.Parameters.AddWithValue("Estado", oGrupoPermiso.Estado);
                    cmd.Parameters.AddWithValue("Componentes", listaComponentes);

                    //Parametros de Salida
                    cmd.Parameters.Add("Resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.NVarChar, 400).Direction = ParameterDirection.Output;

                    cmd.CommandType = CommandType.StoredProcedure;

                    oconexion.Open();

                    cmd.ExecuteNonQuery();

                    resultado = Convert.ToBoolean(cmd.Parameters["Resultado"].Value);
                }
                catch (Exception ex)
                {
                    mensaje = ex.Message;
                    resultado = false;
                }
            }
            return resultado;
        }
        public bool EditarGrupoPermiso(GrupoPermiso oGrupoPermiso, DataTable listaComponentes, out string mensaje)
        {
            bool resultado = false;
            mensaje = string.Empty;

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("SP_EditarGrupoPermiso", oconexion);

                    //Parametros de Entrada
                    cmd.Parameters.AddWithValue("IdGrupoPermiso", oGrupoPermiso.IdGrupoPermiso);
                    cmd.Parameters.AddWithValue("IdComponente", oGrupoPermiso.IdComponente);
                    cmd.Parameters.AddWithValue("NombreGrupo", oGrupoPermiso.NombreGrupo);
                    cmd.Parameters.AddWithValue("Estado", oGrupoPermiso.Estado);
                    cmd.Parameters.AddWithValue("Componentes", listaComponentes);

                    //Parametros de Salida
                    cmd.Parameters.Add("Resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.NVarChar, 400).Direction = ParameterDirection.Output;

                    cmd.CommandType = CommandType.StoredProcedure;

                    oconexion.Open();

                    cmd.ExecuteNonQuery();

                    resultado = Convert.ToBoolean(cmd.Parameters["Resultado"].Value);
                }
                catch (Exception ex)
                {
                    mensaje = ex.Message;
                    resultado = false;
                }
            }
            return resultado;
        }
        public bool EliminarGrupoPermiso(GrupoPermiso oGrupoPermiso, out string mensaje)
        {
            bool resultado = false;
            mensaje = string.Empty;

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("SP_EliminarGrupoPermiso", oconexion);

                    //Parametros de Entrada
                    cmd.Parameters.AddWithValue("IdGrupoPermiso", oGrupoPermiso.IdGrupoPermiso);
                    cmd.Parameters.AddWithValue("IdComponente", oGrupoPermiso.IdComponente);

                    //Parametros de Salida
                    cmd.Parameters.Add("Resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.NVarChar, 400).Direction = ParameterDirection.Output;

                    cmd.CommandType = CommandType.StoredProcedure;
                    
                    oconexion.Open();

                    cmd.ExecuteNonQuery();

                    resultado = Convert.ToBoolean(cmd.Parameters["Resultado"].Value);
                }
                catch (Exception ex)
                {
                    mensaje = ex.Message;
                    resultado = false;
                }
            }
            return resultado;
        }
    }
}
