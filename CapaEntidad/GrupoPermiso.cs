using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class GrupoPermiso : Componente
    {
        //
        //ATRIBUTOS
        //
        private int idGrupoPermiso;
        private string nombreGrupo;
        private string fechaRegistro;

        //
        //PROPIEDADES
        //
        public int IdGrupoPermiso {  get; set; }
        public string NombreGrupo { get; set; }
        public string FechaRegistro { get; set; }
    }
}
