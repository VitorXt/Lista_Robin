using Atv4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atv4
{
    public class ListaAlunos
    {
        public void ListAlunos()
        {
            Console.WriteLine("Quantos alunos deseja inserir?");
            int quantidadeAlunos = Convert.ToInt32(Console.ReadLine());

            List<Aluno> listaAlunos = new List<Aluno>();

            for (int i = 0; i < quantidadeAlunos; i++)
            {
                Aluno aluno = new Aluno();
                aluno.ReceberDados();
                aluno.CalcularNotaFinal();
                aluno.CalcularMedia();
                listaAlunos.Add(aluno);
            }

            foreach (Aluno aluno in listaAlunos)
            {
                Console.WriteLine($"Aluno: {aluno.Nome} ({aluno.RA})");
                Console.WriteLine($"Nota da Prova: {aluno.Notaprova}");
                Console.WriteLine($"Nota do Trabalho: {aluno.Notatrabalho}");
                Console.WriteLine($"Nota Final: {aluno.Notafinal}");
                Console.WriteLine();
            }
        }
    }
}
