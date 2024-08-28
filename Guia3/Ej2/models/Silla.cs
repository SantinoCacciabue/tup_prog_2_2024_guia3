using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej1.models
{
    internal class Silla : Producto
    {
        public Silla(string descripcion, double precioBase, int material) :base(descripcion, precioBase, material) { }
        public override double CalcularPrecio()
        {
            return precioBase * (1 + tipoMaterial * 0.25);
        }
        public override string VerDetalle()
        {
            string mat = "";
            if (tipoMaterial == 0)
            {
                mat = "Pino";
            }
            else if (tipoMaterial == 1)
            {
                mat = "Algarrobo";
            }
            else
            {
                mat = "Caoba";
            }
            return $"{Environment.NewLine}Silla {Descripcion} {mat} {precioBase} {CalcularPrecio()}";
        }
    }
}
