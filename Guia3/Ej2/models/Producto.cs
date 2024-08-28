using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej1
{
    abstract class Producto
    {
        public string Descripcion { get; private set; }
        protected double precioBase;
        protected int tipoMaterial;
        public Producto(string descripcion, double precioBase, int tipoMaterial)
        {
            Descripcion = descripcion;
            this.precioBase = precioBase;
            this.tipoMaterial = tipoMaterial;
        }
        public abstract double CalcularPrecio();
        public abstract string VerDetalle();
    }
}
