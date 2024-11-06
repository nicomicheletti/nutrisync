using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaEntidad;


namespace CapaDatos
{
    public class CD_Permiso
    {
        public List<Permiso> Listar(int idusuario)
        {
            List<Componente> lista = new List<Componente>();

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select c.Nombre, c.TipoComponente, c.Estado, c.IdComponente ");
                    query.AppendLine("from USUARIO_COMPONENTE uc ");
                    query.AppendLine("inner join COMPONENTE c on uc.IdComponente = c.IdComponente ");
                    query.AppendLine("where uc.IdUsuario = @IdUsuario");

                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.Parameters.AddWithValue("@IdUsuario", idusuario);
                    cmd.CommandType = CommandType.Text;

                    oconexion.Open();

                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        Componente componente = new Componente();
                        componente.Nombre = dr["Nombre"].ToString();
                        componente.TipoComponente = dr["TipoComponente"].ToString();
                        componente.Estado = Convert.ToBoolean(dr["Estado"]);
                        componente.IdComponente = Convert.ToInt32(dr["IdComponente"]);

                        lista.Add(componente);
                    }
                }
                catch (Exception ex)
                {
                    List<Permiso> listaPermisos = new List<Permiso>();
                    return listaPermisos;
                }
            }
            return DiferenciarComponentes(lista);
        }

        private List<Permiso> DiferenciarComponentes(List<Componente> lista)
        {
            List<Permiso> listaPermisos = new List<Permiso>();
            List<Componente> listaPermisoComponente = new List<Componente>();
            List<Componente> listaGrupoPermisoComponente = new List<Componente>();

            do
            {
                foreach (Componente componente in lista)
                {
                    if (componente.Estado)
                    {
                        if (componente.TipoComponente == "Permiso")
                        {
                            listaPermisoComponente.Add(componente);
                        }
                        else if (componente.TipoComponente == "GrupoPermiso")
                        {
                            listaGrupoPermisoComponente.Add(componente);
                        }
                    }
                }

                lista.Clear();

                foreach (Componente componentePermiso in listaPermisoComponente)
                {
                    using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                    {
                        try
                        {
                            StringBuilder query = new StringBuilder();
                            query.AppendLine("select p.IdPermiso, p.NombreMenu ");
                            query.AppendLine("from PERMISO p ");
                            query.AppendLine("inner join COMPONENTE c on p.IdComponente = c.IdComponente ");
                            query.AppendLine("where p.IdComponente = @IdComponente");

                            SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                            cmd.Parameters.AddWithValue("IdComponente", componentePermiso.IdComponente);

                            oconexion.Open();

                            SqlDataReader dr = cmd.ExecuteReader();
                            while (dr.Read())
                            {
                                Permiso permiso = new Permiso()
                                {
                                    IdComponente = componentePermiso.IdComponente,
                                    Nombre = componentePermiso.Nombre,
                                    TipoComponente = componentePermiso.TipoComponente,
                                    Estado = componentePermiso.Estado,
                                    IdPermiso = Convert.ToInt32(dr["IdPermiso"]),
                                    NombreMenu = dr["NombreMenu"].ToString()
                                };
                                listaPermisos.Add(permiso);
                            }
                        }
                        catch (Exception ex)
                        {
                            throw new Exception("Hay un error en la base de datos " + ex.Message);
                        }
                    }
                }

                foreach (Componente componenteGrupoPermiso in listaGrupoPermisoComponente)
                {
                    string idGrupoPermiso = "";
                    using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                    {

                        try
                        {
                            StringBuilder query = new StringBuilder();
                            query.AppendLine("select gp.IdGrupoPermiso, c.Nombre ");
                            query.AppendLine("from GRUPO_PERMISO gp ");
                            query.AppendLine("inner join COMPONENTE c on gp.IdComponente = c.IdComponente ");
                            query.AppendLine("where gp.IdComponente = @IdComponente");

                            SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                            cmd.Parameters.AddWithValue("IdComponente", componenteGrupoPermiso.IdComponente);

                            oconexion.Open();

                            SqlDataReader dr = cmd.ExecuteReader();
                            while (dr.Read())
                            {
                                idGrupoPermiso = dr["IdGrupoPermiso"].ToString();
                            }
                        }
                        catch (Exception ex)
                        {
                            throw new Exception("Hay un error en la base de datos " + ex.Message);
                        }
                    }
                    using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                    {
                        try
                        {
                            StringBuilder query = new StringBuilder();
                            query.AppendLine("select c.IdComponente, c.Nombre, c.TipoComponente, c.Estado ");
                            query.AppendLine("from COMPONENTE c ");
                            query.AppendLine("inner join GRUPO_PERMISO_COMPONENTE gpc on gpc.IdComponente = c.IdComponente ");
                            query.AppendLine("where gpc.IdGrupoPermiso = @IdGrupoPermiso ");

                            SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                            cmd.Parameters.AddWithValue("IdGrupoPermiso", idGrupoPermiso);

                            oconexion.Open();

                            SqlDataReader dr = cmd.ExecuteReader();
                            while (dr.Read())
                            {
                                Componente componenteDiferenciado = new Componente()
                                {
                                    IdComponente = Convert.ToInt32(dr["IdComponente"]),
                                    Nombre = dr["Nombre"].ToString(),
                                    TipoComponente = dr["TipoComponente"].ToString(),
                                    Estado = Convert.ToBoolean(dr["Estado"])
                                };
                                lista.Add(componenteDiferenciado);
                            }
                        }
                        catch (Exception ex)
                        {
                            throw new Exception("Hay un error en la base de datos " + ex.Message);
                        }
                    }
                }

                listaPermisoComponente.Clear();
                listaGrupoPermisoComponente.Clear();

            }
            while (lista.Count != 0);

            return listaPermisos;
        }
        public List<Permiso> ListarPermisos()
        {
            List<Permiso> listaPermisos = new List<Permiso>();

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select c.IdComponente, c.Nombre, c.Estado, ");
                    query.AppendLine("p.IdPermiso, p.NombreMenu");
                    query.AppendLine("from COMPONENTE c ");
                    query.AppendLine("inner join PERMISO p on c.IdComponente = p.IdComponente ");

                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.CommandType = CommandType.Text;

                    oconexion.Open();

                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        Permiso permiso = new Permiso();
                        permiso.IdComponente = Convert.ToInt32(dr["IdComponente"]);
                        permiso.Nombre = dr["Nombre"].ToString();
                        permiso.TipoComponente = "Permiso";
                        permiso.Estado = Convert.ToBoolean(dr["Estado"]);
                        permiso.IdPermiso = Convert.ToInt32(dr["IdPermiso"]);
                        permiso.NombreMenu = dr["NombreMenu"].ToString();

                        listaPermisos.Add(permiso);
                    }
                }
                catch (Exception ex)
                {
                    listaPermisos = new List<Permiso>();
                }
            }
            return listaPermisos;
        }
        public bool EditarEstado(int idComponente, bool estado, out string mensaje)
        {
            bool resultado = false;
            mensaje = string.Empty;

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("SP_EditarEstadoPermiso", oconexion);

                    //PARAMETROS DE ENTRADA
                    cmd.Parameters.AddWithValue("IdComponente", idComponente);
                    cmd.Parameters.AddWithValue("Estado", estado);
                    //PARAMETRO DE SALIDA
                    cmd.Parameters.Add("Mensaje", SqlDbType.NVarChar, 400).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    //TIPO DE COMANDO
                    cmd.CommandType = CommandType.StoredProcedure;

                    oconexion.Open();

                    cmd.ExecuteNonQuery();

                    resultado = Convert.ToBoolean(cmd.Parameters["Resultado"].Value);
                    mensaje = cmd.Parameters["Mensaje"].Value.ToString();

                }
                catch (Exception ex)
                {
                    resultado = false;
                }
            }
            return resultado;
        }
    }
}
