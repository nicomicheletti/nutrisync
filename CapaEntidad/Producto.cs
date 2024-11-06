using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Producto
    {
        //
        //ATRIBUTOS
        //
        private int idProducto;
        private string codigo;
        private string nombre;
        private string descripcion;
        private Categoria oCategoria;
        private int stock;
        private decimal precioCompra;
        private decimal precioVenta;
        private bool estado;
        private string fechaRegistro;

        //
        //PROPIEDADES
        //
        public int IdProducto { get; set; }
        public string Codigo { get; set;}
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public Categoria OCategoria { get; set; }
        public int Stock { get; set; }
        public decimal PrecioCompra { get; set; }
        public decimal PrecioVenta { get; set; }
        public bool Estado { get; set; }
        public string FechaRegistro { get; set; }
    }
}
