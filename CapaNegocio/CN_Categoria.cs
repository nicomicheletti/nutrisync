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
    public class CN_Categoria
    {
        private CD_Categoria objcd_categoria = new CD_Categoria();

        public List<Categoria> Listar()
        {
            try
            {
                return objcd_categoria.Listar();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public int Registrar(Categoria obj, out string Mensaje)
        {
            Mensaje = string.Empty;
    
            if (obj.Descripcion == "")
            {
                Mensaje += "Debe introducir la descripcion de la categoria\n";
            }

            if (Mensaje != string.Empty)
            {
                return 0;
            }
            else
            {
                try
                {
                    return objcd_categoria.Registrar(obj, out Mensaje);                    
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }

        }

        public bool Editar(Categoria obj, out string Mensaje)
        {
            Mensaje = string.Empty;

            if (obj.Descripcion == "")
            {
                Mensaje += "Debe introducir la descripcion de la categoria\n";
            }

            if (Mensaje != string.Empty)
            {
                return false;
            }
            else
            {
                try
                {
                    return objcd_categoria.Editar(obj, out Mensaje);
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }
        }

        public bool Eliminar(Categoria obj, out string Mensaje)
        {
            try
            {
                return objcd_categoria.Eliminar(obj, out Mensaje);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
