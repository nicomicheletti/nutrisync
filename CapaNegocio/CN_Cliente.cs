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
    public class CN_Cliente
    {
        private CD_Cliente objcd_cliente = new CD_Cliente();

        public List<Cliente> Listar()
        {
            try
            {
                return objcd_cliente.Listar();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public int Registrar(Cliente obj, out string Mensaje)
        {
            Mensaje = string.Empty;

            if (string.IsNullOrWhiteSpace(obj.Documento))
            {
                Mensaje += "Debe introducir el número de documento del Cliente\n";
            }

            if (string.IsNullOrWhiteSpace(obj.NombreCompleto))
            {
                Mensaje += "Debe introducir el Nombre Completo del Cliente\n";
            }

            if (string.IsNullOrWhiteSpace(obj.Correo))
            {
                Mensaje += "Debe introducir el correo del Cliente\n";
            }

            if (string.IsNullOrWhiteSpace(obj.Telefono))
            {
                Mensaje += "Debe introducir el teléfono del Cliente\n";
            }

            if (string.IsNullOrWhiteSpace(obj.Membresia))
            {
                Mensaje += "Debe especificar el tipo de membresía del Cliente\n";
            }

            if (Mensaje != string.Empty)
            {
                return 0;
            }
            else
            {
                try
                {
                    return objcd_cliente.Registrar(obj, out Mensaje);
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }
        }

        public bool Editar(Cliente obj, out string Mensaje)
        {
            Mensaje = string.Empty;

            if (string.IsNullOrWhiteSpace(obj.Documento))
            {
                Mensaje += "Debe introducir el número de documento del Cliente\n";
            }

            if (string.IsNullOrWhiteSpace(obj.NombreCompleto))
            {
                Mensaje += "Debe introducir el Nombre Completo del Cliente\n";
            }

            if (string.IsNullOrWhiteSpace(obj.Correo))
            {
                Mensaje += "Debe introducir el correo del Cliente\n";
            }

            if (string.IsNullOrWhiteSpace(obj.Telefono))
            {
                Mensaje += "Debe introducir el teléfono del Cliente\n";
            }

            if (string.IsNullOrWhiteSpace(obj.Membresia))
            {
                Mensaje += "Debe especificar el tipo de membresía del Cliente\n";
            }

            if (Mensaje != string.Empty)
            {
                return false;
            }
            else
            {
                try
                {
                    return objcd_cliente.Editar(obj, out Mensaje);
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }
        }

        public bool Eliminar(Cliente obj, out string Mensaje)
        {
            try
            {
                return objcd_cliente.Eliminar(obj, out Mensaje);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
