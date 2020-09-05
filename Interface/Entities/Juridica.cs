using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Interface.Entities
{
    class Juridica:Contribuinte
    {
        public int NumeroFuncionarios { get; set; }

        public Juridica()
        {
        }

        public Juridica(string name, double rendaAnual,int numeroFuncionarios)
            :base (name, rendaAnual)
        {
            NumeroFuncionarios = numeroFuncionarios;
        }

        public override double ImpostoPagar()
        {
            if (NumeroFuncionarios< 10)
            {
                return RendaAnual * 0.16;
            }
            else
            {
                return RendaAnual * 0.14;
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
