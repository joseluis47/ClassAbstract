using Interface.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace Interface
{
    class Program
    {
       

        static void Main(string[] args)
        {


            List<Contribuinte> Contribuintes = new List<Contribuinte>();
            Console.Write("Enter the number of tax payers: ");
            int quantidade = int.Parse(Console.ReadLine());

            for (int i = 0; i < quantidade; i++)
            {
                Console.WriteLine($"Tax payer #{i + 1} data:");
                Console.Write("Individual or company(i / c) ?");
                string tipo = Console.ReadLine();
                if (tipo == "i")
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Anual income: ");
                    double renda = double.Parse(Console.ReadLine());
                    Console.Write("Health expenditures:");
                    double saude = double.Parse(Console.ReadLine());
                    Fisica fisica = new Fisica(name, renda, saude);
                    Contribuintes.Add(fisica);
                }
                if (tipo == "c")
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Anual income: ");
                    double renda = double.Parse(Console.ReadLine());
                    Console.Write("Number of employees:");
                    int funcionarios = int.Parse(Console.ReadLine());
                    Juridica juridica = new Juridica(name, renda, funcionarios);
                    Contribuintes.Add(juridica);
                }
            }

            Console.WriteLine();
            double TotalImposto = 0;
            Console.WriteLine("TAXES PAID: ");
            foreach (var item in Contribuintes)
            {
                Console.WriteLine(item.Imprimir());
                TotalImposto += item.ImpostoPagar();
            }
            Console.WriteLine();
            Console.WriteLine($"TOTAL TAXES: $ {TotalImposto.ToString("F2",CultureInfo.InvariantCulture)}");
        }
    }
}
