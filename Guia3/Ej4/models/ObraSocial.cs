using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej4.models
{
    internal class ObraSocial : Prestacion
    {
        public double Arancel {  get; set; }
        public int ConsultasMensuales { get;private set; }
        public ObraSocial(string nombre, Prestador medico) : base(medico, nombre)
        {

        }
        public override double PrestarServicio()
        {
            MontoTotal += Arancel;
            double monto;
            monto = 0;
            ConsultasMensuales++;
            if (ConsultasMensuales > 2)
            {
                monto = 250;
            }
            monto = Arancel;
            return monto;
        }
    }
}
