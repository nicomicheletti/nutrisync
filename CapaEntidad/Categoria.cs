﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Categoria
    {
        //
        //ATRIBUTOS
        //
        private int idCategoria;
        private string descripcion;
        private bool estado;
        private string fechaRegistro;

        //
        //PROPIEDADES
        //
        public int IdCategoria { get; set; }
        public string Descripcion { get; set; }
        public bool Estado { get; set; }
        public string FechaRegistro { get; set; }
    }
}
