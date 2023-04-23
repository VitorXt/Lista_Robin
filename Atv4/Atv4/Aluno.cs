using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atv4
{
    public class Aluno
    {
        public string RA;
        public string Nome;
        public decimal Notaprova;
        public decimal Notatrabalho;
        public decimal Notafinal;

        public void CalcularMedia()
        {
            decimal media = (Notaprova + Notatrabalho) / 2;

            Console.WriteLine(media);
        }

        public void CalcularNotaFinal()
        {
            Notafinal = Notaprova + Notatrabalho;
        }

        public void ReceberDados()
        {
            Console.WriteLine("Digite o seu RA:");
            RA = Console.ReadLine();

            Console.WriteLine("Digite o seu nome:");
            Nome = Console.ReadLine();

            Console.WriteLine("Digite o valor da prova:");
            Notaprova = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Digite o valor do trabalho:");
            Notatrabalho = Convert.ToDecimal(Console.ReadLine());

        }

        public void ImprimirNotaFinal()
        {
            Console.WriteLine($"A sua nota final é de: {Notafinal}");
        }

    }

}
