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
        public string nome;
        public decimal notaprova;
        public decimal notatrabalho;
        public decimal notafinal;

        public void CalcularMedia()
        {
            notafinal = notaprova + notatrabalho;
        }
        public bool CalcularNotaFinal(decimal notafinal)
        {
            if (notafinal >= 14)
            {
                Console.WriteLine("Você foi aprovado");
                return true;
            }
            else
            {
                Console.WriteLine($"Você está na prova final, precisa de: {14 - notafinal}");
                return false;
            }
        }

        public void ImprimirNotaFinal()
        {
            Console.WriteLine($"Sua Nota final é : {notafinal}");
        }
        public void ReceberDados()
        {
            Console.WriteLine($"RA: {RA}");
            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine($"Nota da prova: {notaprova}");
            Console.WriteLine($"Nota do trabalho: {notatrabalho}");
        }
    }
}
