using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ej1;

namespace Ej2.models
{
    internal class Presupuesto
    {
        private ArrayList presupuestados = new ArrayList();
        public int CantidadProductos
        {
            get
            {
                return presupuestados.Count;
            }
        }
        public double CostoTotal
        {
            get
            {
                double acum = 0;
                foreach(Producto p in presupuestados)
                {
                    acum += p.CalcularPrecio();
                }
                return acum;
            }
        }
        public string Cliente { get; set; }
        public string Direccion {  get; set; }
        public Presupuesto(string cliente, string direccion)
        {
            Cliente = cliente;
            Direccion = direccion;
        }
        public void AgregarProducto(Producto producto)
        {
            presupuestados.Add(producto);
        }
        public Producto VerProducto(int idx)
        {
            if(idx>=0 && idx<CantidadProductos)
            {
                return  presupuestados[idx] as Producto;
            }
            return null;
        }
    }
}
