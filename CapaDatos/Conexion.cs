using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class Conexion
    {
        public static string cadena = ConfigurationManager.ConnectionStrings["cadena_conexion"].ToString();

        /*SqlConnection conexion;

        public static SqlConnection GetConnection()
        {
            try
            {
                //Instanciamos la conexion
                SqlConnection conexion = new SqlConnection(cadena);

                //Abrimos la conexion
                conexion.Open();

                //Retornamos la conexion
                return conexion;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }*/
    }
}
