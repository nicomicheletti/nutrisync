using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    public class CN_Usuario
    {
        private CD_Usuario objcd_usuario = new CD_Usuario();

        public List<Usuario> Listar()
        {
            try
            {
                return objcd_usuario.Listar();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public int Registrar(Usuario obj, out string Mensaje)
        {
            Mensaje = string.Empty;

            if (obj.Documento == "")
            {
                Mensaje += "Debe introducir el número de documento del usuario\n";
            }

            if (obj.NombreCompleto == "")
            {
                Mensaje += "Debe introducir el nombre completo del usuario\n";
            }

            if (obj.Correo == "")
            {
                Mensaje += "Debe introducir el correo del usuario\n";
            }


            if (obj.Clave == "")
            {
                Mensaje += "Debe introducir la clave del usuario\n";
            }

            if (Mensaje !=  string.Empty)
            {
                return 0;
            }
            else
            {
                try
                {
                    return objcd_usuario.Registrar(obj, out Mensaje);
                }
                catch(Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }
            
        }

        public bool Editar(Usuario obj, out string Mensaje)
        {
            Mensaje = string.Empty;

            if (obj.Documento == "")
            {
                Mensaje += "Debe introducir el número de documento del usuario\n";
            }

            if (obj.NombreCompleto == "")
            {
                Mensaje += "Debe introducir el nombre completo del usuario\n";
            }

            if (obj.Correo == "")
            {
                Mensaje += "Debe introducir el correo del usuario\n";
            }
 
            if (obj.Clave == "")
            {
                Mensaje += "Debe introducir la clave del usuario\n";
            }

            if (Mensaje != string.Empty)
            {
                return false;
            }
            else
            {
                try
                {
                    return objcd_usuario.Editar(obj, out Mensaje);
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }
        }

        public bool Eliminar(Usuario obj, out string Mensaje)
        {
            try
            {
                return objcd_usuario.Eliminar(obj, out Mensaje);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
