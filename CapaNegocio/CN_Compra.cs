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
    public class CN_Compra
    {
        private CD_Compra objcd_compra = new CD_Compra();

        public List<Compra> Listar()
        {
            try
            {
                return objcd_compra.Listar();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public int ObtenerCorrelativo()
        {
            try
            {
                return objcd_compra.ObtenerCorrelativo();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool Registrar(Compra obj,DataTable DetalleCompra, out string Mensaje)
        {
            try
            {
                return objcd_compra.Registrar(obj, DetalleCompra ,out Mensaje);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Compra ObtenerCompra(string numero)
        {
            Compra oCompra = objcd_compra.ObtenerCompra(numero);

            if (oCompra.IdCompra != 0)
            {
                List<Detalle_Compra> oDetalleCompra = objcd_compra.ObtenerDetalleCompra(oCompra.IdCompra);

                oCompra.ODetalleCompra = oDetalleCompra;
            }
            try
            {
                return oCompra;
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
