using System;
using System.Collections.Generic;
using System.Text;

namespace Interface.Entities
{
   abstract class Contribuinte
    {
        public string Name { get; set; }
        public double RendaAnual { get; set; }

        protected Contribuinte()
        {
        }

        protected Contribuinte(string name, double rendaAnual)
        {
            Name = name;
            RendaAnual = rendaAnual;
        }

        public abstract double ImpostoPagar();
        public abstract string Imprimir();


    }
}
