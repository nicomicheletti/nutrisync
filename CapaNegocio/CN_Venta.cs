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
    public class CN_Venta
    {
        private CD_Venta objcd_venta = new CD_Venta();

        public List<Venta> Listar()
        {
            try
            {
                return objcd_venta.Listar();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<AuditoriaVenta> ListarAuditoria()
        {
            try
            {
                return objcd_venta.ListarAuditoria();
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
                return objcd_venta.ObtenerCorrelativo();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool Registrar(Venta obj, DataTable DetalleVenta, out string Mensaje)
        {
            try
            {
                return objcd_venta.Registrar(obj, DetalleVenta, out Mensaje);
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool RestarStock(int idproducto, int cantidad)
        {
            try
            {
                return objcd_venta.RestarStock(idproducto, cantidad);   
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool SumarStock(int idproducto, int cantidad)
        {
            try
            {
                return objcd_venta.SumarStock(idproducto, cantidad);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Venta ObtenerVenta(string numero)
        {
            Venta oVenta = objcd_venta.ObtenerVenta(numero);

            if (oVenta.IdVenta != 0)
            {
                List<Detalle_Venta> oDetalleVenta = objcd_venta.ObtenerDetalleVenta(oVenta.IdVenta);
                oVenta.ODetalleVenta = oDetalleVenta;
            }
            try
            {
                return oVenta;  
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
