using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Negocio
    {
        private CD_Negocio objcd_Negocio = new CD_Negocio();

        public Negocio ObtenerDatos()
        {
            try
            {
                return objcd_Negocio.ObtenerDatos();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool GuardarDatos(Negocio obj, out string Mensaje)
        {
            Mensaje = string.Empty;

            if (obj.Nombre == "")
            {
                Mensaje += "Debe introducir el nombre del Negocio\n";
            }

            if (obj.RUC == "")
            {
                Mensaje += "Debe introducir el R.U.C del Negocio\n";
            }

            if (obj.Direccion == "")
            {
                Mensaje += "Debe introducir la dirección del Negocio\n";
            }

            if (Mensaje != string.Empty)
            {
                return false;
            }
            else
            {
                try
                {
                    return objcd_Negocio.GuardarDatos(obj, out Mensaje);
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }

        }

        public byte[] ObtenerLogo(out bool obtenido)
        {
            try
            {
                return objcd_Negocio.ObtenerLogo(out obtenido);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool ActualizarLogo(byte[] imagen, out string mensaje)
        {
            try
            {
                return objcd_Negocio.ActualizarLogo(imagen, out mensaje);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
