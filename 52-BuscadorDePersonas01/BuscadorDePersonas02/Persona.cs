using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BuscadorDePersonas02
{
    class Persona
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        public string Hablar()
        {
            return "El registro muestra a:" + " " + this.Nombre +" "+ this.Apellido;
        }
    }
}
