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
    public class CN_Producto
    {
        private CD_Producto objcd_producto = new CD_Producto();

        public List<Producto> Listar()
        {
            try
            {
                return objcd_producto.Listar();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public int Registrar(Producto obj, out string Mensaje)
        {
            Mensaje = string.Empty;

            if (obj.Codigo == "")
            {
                Mensaje += "Debe introducir el codigo del producto\n";
            }

            if (obj.Nombre == "")
            {
                Mensaje += "Debe introducir el nombre del producto\n";
            }

            if (obj.Descripcion == "")
            {
                Mensaje += "Debe introducir la descripción del producto\n";
            }

            if (Mensaje != string.Empty)
            {
                return 0;
            }
            else
            {
                try
                {
                    return objcd_producto.Registrar(obj, out Mensaje);
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }

        }

        public bool Editar(Producto obj, out string Mensaje)
        {
            Mensaje = string.Empty;

            if (obj.Codigo == "")
            {
                Mensaje += "Debe introducir el codigo del producto\n";
            }

            if (obj.Nombre == "")
            {
                Mensaje += "Debe introducir el nombre del producto\n";
            }

            if (obj.Descripcion == "")
            {
                Mensaje += "Debe introducir la descripción del producto\n";
            }

            if (Mensaje != string.Empty)
            {
                return false;
            }
            else
            {
                try
                {
                    return objcd_producto.Editar(obj, out Mensaje);
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }
        }

        public bool Eliminar(Producto obj, out string Mensaje)
        {
            try
            {
                return objcd_producto.Eliminar(obj, out Mensaje);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
