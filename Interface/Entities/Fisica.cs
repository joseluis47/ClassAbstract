using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Interface.Entities
{
    class Fisica: Contribuinte
    {
        public double GastosSaude { get; set; }

        public Fisica()
        {
        }

        public Fisica(string Name, double RendaAnual , double gastosSaude)
            :base (Name, RendaAnual)
        {
            GastosSaude = gastosSaude;
        }

        public override double ImpostoPagar()
        {
           if (RendaAnual<20000)
            {
                return RendaAnual * 0.15 - GastosSaude * 0.5;
            } else
            {
                return RendaAnual * 0.2 - GastosSaude * 0.5;
            }
        }

        public override string Imprimir()
        {
            return
                Name +
                ": $ " +
                ImpostoPagar().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
