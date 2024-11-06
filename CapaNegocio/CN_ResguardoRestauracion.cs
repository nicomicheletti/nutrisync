using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_ResguardoRestauracion
    {
        private CD_ResguardoRestauracion objcd_res = new CD_ResguardoRestauracion();

        public bool Resguardo(out string Mensaje)
        {
            Mensaje = string.Empty;
            try
            {
                return objcd_res.Resguardo(out Mensaje);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool Restauracion(out string Mensaje)
        {
            Mensaje = string.Empty;
            try
            {
                return objcd_res.Restauracion(out Mensaje);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
