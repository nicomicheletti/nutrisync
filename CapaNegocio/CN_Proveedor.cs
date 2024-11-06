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
    public class CN_Proveedor
    {
        private CD_Proveedor objcd_Proveedor = new CD_Proveedor();

        public List<Proveedor> Listar()
        {
            try
            {
                return objcd_Proveedor.Listar();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public int Registrar(Proveedor obj, out string Mensaje)
        {
            Mensaje = string.Empty;

            if (obj.Documento == "")
            {
                Mensaje += "Debe introducir el número de documento del Proveedor\n";
            }

            if (obj.RazonSocial == "")
            {
                Mensaje += "Debe introducir la razon social del Proveedor\n";
            }

            if (obj.Correo == "")
            {
                Mensaje += "Debe introducir el correo del Proveedor\n";
            }

            if (obj.Telefono == "")
            {
                Mensaje += "Debe introducir el telefono del Proveedor\n";
            }

            if (Mensaje != string.Empty)
            {
                return 0;
            }
            else
            {
                try
                {
                    return objcd_Proveedor.Registrar(obj, out Mensaje);
                }
                catch (Exception ex) 
                {
                    throw new Exception(ex.Message);
                }
            }

        }

        public bool Editar(Proveedor obj, out string Mensaje)
        {
            Mensaje = string.Empty;

            if (obj.Documento == "")
            {
                Mensaje += "Debe introducir el número de documento del Proveedor\n";
            }

            if (obj.RazonSocial == "")
            {
                Mensaje += "Debe introducir la razon social del Proveedor\n";
            }

            if (obj.Correo == "")
            {
                Mensaje += "Debe introducir el correo del Proveedor\n";
            }

            if (obj.Telefono == "")
            {
                Mensaje += "Debe introducir el telefono del Proveedor\n";
            }

            if (Mensaje != string.Empty)
            {
                return false;
            }
            else
            {
                try
                {
                    return objcd_Proveedor.Editar(obj, out Mensaje);    
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }
        }

        public bool Eliminar(Proveedor obj, out string Mensaje)
        {
            try
            {
                return objcd_Proveedor.Eliminar(obj, out Mensaje);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
