using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Detalle_Compra
    {
        //
        //ATRIBUTOS
        //
        private int idDetalleCompra;
        private Producto oProducto;
        private decimal precioCompra;
        private decimal precioVenta;
        private int cantidad;
        private decimal montoTotal;
        private string fechaRegistro;

        //
        //PROPIEDADES
        //
        public int IdDetalleCompra { get; set; }
        public Producto OProducto { get; set; }
        public decimal PrecioCompra { get; set; }
        public decimal PrecioVenta { get; set; }
        public int Cantidad { get; set; }
        public decimal MontoTotal { get; set; }
        public string FechaRegistro { get; set; }
    }
}
