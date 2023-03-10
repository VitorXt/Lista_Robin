using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Atv2.Calculo;


namespace Atv2{
    
    public class Calculadora
    {
        Calculo calculo = new Calculo();

    public void ExecutarCalculadora(){
        Console.Write("Digite o primeiro valor: ");
        calculo.ValorA = double.Parse(Console.ReadLine());
        Console.Write("Digite o segundo valor: ");
        calculo.ValorB = double.Parse(Console.ReadLine());

            int opcao = 0;
            while (opcao != 6)
            {
                Console.WriteLine(" ");
                Console.WriteLine("Qual operacao deseja fazer?");
                Console.WriteLine("1 - Soma");
                Console.WriteLine("2 - Subtracao");
                Console.WriteLine("3 - Multiplicacao");
                Console.WriteLine("4 - Retornar o maior");
                Console.WriteLine("5 - Valor a ser somado com os 2 anteriores");
                Console.WriteLine("6 - Sair!! ");
                Console.WriteLine(" ");
                Console.Write("Selecione uma opção: ");
                opcao = int.Parse(Console.ReadLine());


            switch (opcao){
                case 1:
                    calculo.CalcularSoma();          
                    break;
                case 2:
                    calculo.CalcularSubtracao();
                    break;
                case 3:
                    calculo.CalcularMultiplicacao();
                    break;
                case 4:
                    calculo.RetornarMaior();
                    calculo.ImprimirResultado();
                    break;
                case 5:
                    double resultado = calculo.SomarGeral(5);
                    Console.WriteLine($"O resultado é: {resultado}");
                    break;
                case 6:
                    Console.WriteLine("Saindo...");
                    break;
                default:
                    Console.WriteLine("Opção inválida!");
                    break;

                }
            }
        }
    }    
  }

