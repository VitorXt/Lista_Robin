using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atv7
{
    class Horista : Empregado
    {
        public double preco_horas { get; private set; }
        public double Horas_trabalhadas { get; private set; }

        public double salario_horas { get; private set; }

        public override double Vencimento(double horas)
        {
            preco_horas = horas;

            Console.WriteLine("Quantas hora trabalhadas: ");
            Horas_trabalhadas = double.Parse(Console.ReadLine());
            salario_horas = preco_horas * Horas_trabalhadas;

            return salario_horas;
        }
    }
}
