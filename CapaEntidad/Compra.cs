using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Compra
    {
        //
        //ATRIBUTOS
        //
        private int idCompra;
        private Usuario oUsuario;
        private Proveedor oProveedor;
        private string tipoDocumento;
        private string numeroDocumento;
        private decimal montoTotal;
        private List<Detalle_Compra> oDetalleCompra;
        private string fechaRegistro;

        //
        //PROPIEDADES
        //
        public int IdCompra { get; set; }
        public Usuario OUsuario { get; set; }
        public Proveedor OProveedor { get; set; }
        public string TipoDocumento { get; set; }
        public string NumeroDocumento { get; set; }
        public decimal MontoTotal { get; set; }
        public List<Detalle_Compra> ODetalleCompra { get; set; }
        public string FechaRegistro { get; set; }
    }
}
