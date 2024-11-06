using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class AuditoriaVenta
    {
        //
        //ATRIBUTOS
        //
        private int idAuditoria;
        private Venta oVenta;
        private Usuario oUsuario;
        private string fechaAuditoria;
        private string operacion;

        //
        //PROPIEDADES
        //
        public int IdAuditoria { get; set; }
        public Venta OVenta { get; set; }
        public Usuario OUsuario { get; set; }
        public string FechaAuditoria { get; set; }
        public string Operacion { get; set; }
    }
}
