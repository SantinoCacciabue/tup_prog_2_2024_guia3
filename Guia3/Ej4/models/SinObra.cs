using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej4.models
{
    internal class SinObra : Prestacion
    {
        public string CUIT { get; private set; }
        public double ImporteFijo { get; set; }
        public SinObra(string nombre, string cuit, Prestador medico) : base(medico, nombre)
        {
            CUIT = cuit;
        }
        public override double PrestarServicio()
        {
            ImporteFijo = 250;
            MontoTotal += ImporteFijo;
            return ImporteFijo;
        }
    }
}
