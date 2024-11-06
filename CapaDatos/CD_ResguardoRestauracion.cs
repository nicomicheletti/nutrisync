using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_ResguardoRestauracion
    {
        public bool Resguardo(out string Mensaje)
        {
            Mensaje = string.Empty;
            bool respuesta;
            string fechaResguardo = DateTime.Now.ToString("yyyyMMddHHmmss");
            string nombreArchivo = "Resguardo_" + fechaResguardo + ".bak";
            string rutaResguardo = @"C:\BackUp_Sistema\" + nombreArchivo;

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {                    
                    oconexion.Open();
                    string query = "BACKUP DATABASE DB_NUTRISYNC TO DISK = '" + rutaResguardo + "'";
                    SqlCommand command = new SqlCommand(query, oconexion);
                    command.ExecuteNonQuery();
                    respuesta = true;
                }
                catch (Exception ex)
                {
                    Mensaje = ex.Message;
                    respuesta = false;
                }
            }
            return respuesta;
        }

        private string connectionString = "Data Source=DESKTOP-CUCT4QB\\SQLEXPRESS;Initial Catalog=ejer1;Integrated Security=True";

        public bool Restauracion(out string Mensaje)
        {
        Mensaje = string.Empty;
            bool respuesta;
            string carpetaResguardo = @"C:\BackUp_Sistema\";
            string[] archivosResguardo = Directory.GetFiles(carpetaResguardo, "Resguardo_*.bak");
            string archivoResguardo = archivosResguardo.OrderByDescending(f => new FileInfo(f).LastWriteTime).First();
            string nombreBaseDatos = "DB_NUTRISYNC";

            using (SqlConnection oconexion = new SqlConnection(connectionString))
            {
                try
                {
                    oconexion.Open();
                    string query = "ALTER DATABASE " + nombreBaseDatos + " SET SINGLE_USER WITH ROLLBACK IMMEDIATE; " +
                           "RESTORE DATABASE " + nombreBaseDatos + " FROM DISK = '" + archivoResguardo + "' WITH REPLACE; " +
                           "ALTER DATABASE " + nombreBaseDatos + " SET MULTI_USER;";
                    SqlCommand command = new SqlCommand(query, oconexion);
                    command.ExecuteNonQuery();
                    respuesta = true;
                }
                catch (Exception ex)
                {
                    Mensaje = ex.Message;
                    respuesta = false;
                }
            }
            return respuesta;
        }
    }
}
