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
    public class CD_Pago
    {//Creacion de instancia
        private Capa_Dato conexion = new Capa_Dato();

        SqlDataReader leer;
        DataTable table = new DataTable();
        SqlCommand cmd = new SqlCommand();

        //Mostrar datos
        public DataTable mostrar()
        {
            cmd.Connection = conexion.Abrir();
            cmd.CommandText = "sp_MostrarPagos";
            cmd.CommandType = CommandType.StoredProcedure;
            leer = cmd.ExecuteReader();
            table.Load(leer);
            conexion.Cerrar();
            return table;
        }

        public DataTable llenar_socios()
        {
            cmd.Connection = conexion.Abrir();
            cmd.CommandText = "SELECT IdCliente, documento FROM CLIENTES";
            cmd.CommandType = CommandType.Text;
            leer = cmd.ExecuteReader();
            table.Load(leer);
            conexion.Cerrar();
            return table;
        }

        public DataTable llenar_cuotas()
        {
            cmd.Connection = conexion.Abrir();
            cmd.CommandText = "SELECT cod_cuota, mes_cuota, anio_cuota FROM Cuotas";
            cmd.CommandType = CommandType.Text;
            leer = cmd.ExecuteReader();
            table.Load(leer);
            conexion.Cerrar();
            return table;
        }

        //Alta
        public void Insert(int Socio, int Cuota, DateTime Fecha)
        {
            cmd.Connection = conexion.Abrir();
            cmd.CommandText = "sp_AltaPago";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@IdCliente", Socio);
            cmd.Parameters.AddWithValue("@cod_cuota", Cuota);
            cmd.Parameters.AddWithValue("@fecha_pago", Fecha);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
        }

        //Modificar
        public void Update(int Id, int Socio, int Cuota, DateTime Fecha)
        {
            cmd.Connection = conexion.Abrir();
            cmd.CommandText = "sp_ModificarPago";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@cod_pago", Id);
            cmd.Parameters.AddWithValue("@IdCliente", Socio);
            cmd.Parameters.AddWithValue("@cod_cuota", Cuota);
            cmd.Parameters.AddWithValue("@fecha_pago", Fecha);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
        }


        //Baja
        public void Delete(int Id)
        {
            cmd.Connection = conexion.Abrir();
            cmd.CommandText = "sp_BajaPago";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@cod_pago", Id);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
        }

        //FILTRO
        
    }
}
