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
    public class CD_UsuarioPermiso
    {
        public List<Componente> ListarComponentesPorId(int idUsuario)
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

                    cmd.Parameters.AddWithValue("@IdUsuario", idUsuario);

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

                        lista.Add(componente);
                    }
                }
                catch (Exception ex)
                {
                    lista = new List<Componente>();
                }
            }
            return lista;
        }
        public bool EditarUsuarioPermiso(int idUsuario, DataTable lista, out string mensaje)
        {
            bool resultado = false;
            mensaje = string.Empty;

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("SP_EditarUsuarioPermiso", oconexion);

                    //Paramentros de Entrada
                    cmd.Parameters.AddWithValue("IdUsuario", idUsuario);
                    cmd.Parameters.AddWithValue("Componentes", lista);

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
