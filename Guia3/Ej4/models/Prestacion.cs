using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej4.models
{
    abstract class Prestacion : Persona
    {
        public double MontoTotal { get; set; }
        protected Prestador Medico { get;private set; }
        public Prestacion(Prestador medico, string nombre) : base(nombre)
        {
            Medico = medico;
        }
        public abstract double PrestarServicio();

    }
}
