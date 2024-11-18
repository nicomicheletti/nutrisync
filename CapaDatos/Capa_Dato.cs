using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class Capa_Dato
    {
        //Cadena de conexion
        private SqlConnection Conexion = new SqlConnection("Data Source=CQE14\\SQLEXPRESS;Initial Catalog=DB_NUTRISYNC;Integrated Security=true");

        //Abrir conexion
        public SqlConnection Abrir()
        {
            if (Conexion.State == ConnectionState.Closed)
            {
                Conexion.Open();
            }
            return Conexion;
        }

        //Cerrar conexion
        public SqlConnection Cerrar()
        {
            if (Conexion.State == ConnectionState.Open)
            {
                Conexion.Close();
            }
            return Conexion;
        }
    }
}
