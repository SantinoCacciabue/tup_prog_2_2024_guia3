using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej4.models
{
    internal class Prestador : Persona
    {
        ArrayList consultas = new ArrayList();
        public Prestador(string nombre) : base(nombre) { }
        public void AgregarConsulta(Prestacion consulta)
        {
            consultas.Add(consulta);
        }
        public double GenerarPago()
        {
            double monto = 0;
            foreach(Prestacion c in consultas)
            {
                monto = c.MontoTotal;
            }
            return monto;
        }
    }
}
