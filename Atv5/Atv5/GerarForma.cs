using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Atv5
{
    class GerarForma
    {

    }
    public void SolicitarForma()
    {
        int opcao = 0;

        while (opcao != 5)
        {
            Console.WriteLine(" ");
            Console.WriteLine("Menu de Opções:");
            Console.WriteLine("1) Circunferencia");
            Console.WriteLine("2) Quadrado");
            Console.WriteLine("3) Triangulo");
            Console.WriteLine("4) Hexagono");
            Console.WriteLine("5) Sair");
            Console.WriteLine(" ");
            Console.Write("Selecione uma opção: ");
            opcao = int.Parse(Console.ReadLine());


            switch (opcao)
            {
                case 1:
                    Circunferencia();
                    break;
                case 2:
                    Quadrado();
                    break;
                case 3:
                    Triangulo();
                    break;
                case 4:
                    Hexagono();
                    break;
                case 5:
                    Console.WriteLine("Saindo...");
                    break;
                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }

            Console.WriteLine();
        }
    }

}
