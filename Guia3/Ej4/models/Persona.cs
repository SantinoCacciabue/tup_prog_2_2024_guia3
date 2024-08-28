using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej4.models
{
    abstract class Persona
    {
        public string Nombre { get; private set; }
        public Persona(string nombre)
        {
            Nombre = nombre;
        }
    }
}
