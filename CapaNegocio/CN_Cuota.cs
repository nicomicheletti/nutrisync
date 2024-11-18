using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Cuota
    {
        //Nueva instancia
        private CD_Cuota cdCuo = new CD_Cuota();

        //Controladora
        public DataTable mostrarCuotas()
        {
            DataTable table = new DataTable();
            table = cdCuo.mostrar();
            return table;
        }
        public void insertCuota(int Cuota, string Mes, string Anio, int Precio)
        {
            cdCuo.Insert(Convert.ToInt32(Cuota), Mes, Anio, Convert.ToInt32(Precio));
        }
        public void updateCuota(int Cuota, string Mes, string Anio, int Precio)
        {
            cdCuo.Update(Convert.ToInt32(Cuota), Mes, Anio, Convert.ToInt32(Precio));
        }
        public void deleteCuota(int Cuota)
        {
            cdCuo.Delete(Convert.ToInt32(Cuota));
        }
    }
}
