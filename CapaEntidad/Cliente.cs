﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Cliente
    {
        //
        // ATRIBUTOS
        //
        private int idCliente;
        private string documento;
        private string nombreCompleto;
        private string correo;
        private string telefono;
        private bool estado;
        private string fechaRegistro;
        private string membresia;

        //
        // PROPIEDADES
        //
        public int IdCliente { get; set; }
        public string Documento { get; set; }
        public string NombreCompleto { get; set; }
        public string Correo { get; set; }
        public string Telefono { get; set; }
        public bool Estado { get; set; }
        public string FechaRegistro { get; set; }
        public string Membresia { get; set; } // Nuevo campo
    }
}
