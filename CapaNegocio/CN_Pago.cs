using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Pago
    {
        //Nueva instancia
        private CD_Pago cdPago = new CD_Pago();

        //Controladora
        public DataTable mostrarPagos()
        {
            DataTable table = new DataTable();
            table = cdPago.mostrar();
            return table;
        }
        public DataTable listar_cuotas()
        {
            DataTable table = new DataTable();
            table = cdPago.llenar_cuotas();
            return table;
        }
        public DataTable listar_socios()
        {
            DataTable table = new DataTable();
            table = cdPago.llenar_socios();
            return table;
        }
        public void insertPago(int Socio, int Cuota, DateTime Fecha)
        {
            cdPago.Insert(Convert.ToInt32(Socio), Cuota, Fecha);
        }
        public void updatePago(int Id, int Socio, int Cuota, DateTime Fecha)
        {
            cdPago.Update(Id, Socio, Cuota, Fecha);
        }

        public void deletePago(int Id)
        {
            cdPago.Delete(Convert.ToInt32(Id));
        }
    }
}
