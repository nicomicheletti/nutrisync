using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Venta
    {
        //
        //ATRIBUTOS
        //
        private int idVenta;
        private Usuario oUsuario;
        private string tipoDocumento;
        private string numeroDocumento;
        private string documentoCliente;
        private string nombreCliente;
        private decimal montoPago;
        private decimal montoCambio;
        private decimal montoTotal;
        private List<Detalle_Venta> oDetalleVenta;
        private string fechaRegistro;

        //
        //PROPIEDADES
        //
        public int IdVenta { get; set; }
        public Usuario OUsuario { get; set; }
        public string TipoDocumento { get; set; }
        public string NumeroDocumento { get; set; }
        public string DocumentoCliente { get; set; }
        public string NombreCliente { get; set; }
        public decimal MontoPago { get; set; }
        public decimal MontoCambio { get; set; }
        public decimal MontoTotal { get; set;}
        public List<Detalle_Venta> ODetalleVenta { get; set; }
        public string FechaRegistro { get; set; }
    }
}
