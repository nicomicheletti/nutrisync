using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Componente
    {
        //
        //ATRIBUTOS
        //
        private int idComponente;
        private string nombre;
        private string tipoComponente;
        private bool estado;
        private string fechaRegistro;

        //
        //PROPIEDADES
        //
        public int IdComponente { get; set; }
        public string Nombre { get; set; }
        public string TipoComponente { get; set; }
        public bool Estado { get; set; }
        public string FechaRegistro { get; set; }
    }
}
