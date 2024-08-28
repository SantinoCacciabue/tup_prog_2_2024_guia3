using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej1.models
{
    internal class Mesa : Producto
    {
        public double Largo { get; private set; }
        public Mesa(string descripcion, double precioBase, int material, double largo) : base(descripcion,precioBase,material)
        {
            Largo = largo;
        }
        public override double CalcularPrecio()
        {
            return (precioBase * Largo) * (1 + tipoMaterial * 0.33);
        }
        public override string VerDetalle()
        {
            string mat = "";
            if(tipoMaterial == 0)
            {
                mat = "Pino";
            }
            else if(tipoMaterial == 1)
            {
                 mat = "Algarrobo";
            }
            else
            {
                 mat = "Caoba";
            }
            return $"{Environment.NewLine}Mesa {Descripcion} {mat} {precioBase} Largo:{Largo} {CalcularPrecio()}"; 
        }
    }
}
