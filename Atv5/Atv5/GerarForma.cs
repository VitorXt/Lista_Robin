using Atv5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atv5
{
    public class GerarForma
    {
        public void SolicitarForma()
        {
            Console.WriteLine("Abaixo irá aparecer opções onde você deverá escolhar qual forma geométrica irá trabalhar:");
            Console.WriteLine();
            int Forma;

            do
            {
                Console.WriteLine();
                Console.WriteLine(" Digite 1 para Quadrado: \n Digite 2 para Triângulo: \n Digite 3 para Circuferência: \n Digite 4 para sair do programa:");
                Forma = Convert.ToInt32(Console.ReadLine());
                switch (Forma)
                {

                    case 1:

                        Quadrado quadrado = new Quadrado();
                        Console.Clear();
                        Console.WriteLine("Você Selecionou Quadrado");
                        Console.WriteLine("Digite o LadoA do quadrado:");
                        quadrado.LadoA = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Digite o LadoB do quadrado:");
                        quadrado.LadoB = Convert.ToDouble(Console.ReadLine());
                        quadrado.CalcularArea();
                        quadrado.CalcularPerimero();
                        break;

                    case 2:

                        Triangulo triangulo = new Triangulo();
                        Console.Clear();
                        Console.WriteLine("Você Selecionou Triângulo");
                        Console.WriteLine("Digite LadoA do triângulo:");
                        triangulo.LadoA = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Digite LadoB do triângulo:");
                        triangulo.LadoB = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Digite a Base do triângulo:");
                        triangulo.LadoC = Convert.ToDouble(Console.ReadLine());
                        triangulo.CalcularArea();
                        triangulo.CalcularPerimero();
                        break;

                    case 3:

                        Circunferencia circ = new Circunferencia();
                        Console.Clear();
                        Console.WriteLine("Você Selecionou Circunferência");
                        Console.WriteLine("Digite o raio da circunferência:");
                        circ.raio = Convert.ToDouble(Console.ReadLine());
                        circ.CalcularArea();
                        circ.CalcularPerimero();
                        break;

                    case 4:

                        Console.WriteLine("Obrigado por utilizar o sistema");
                        break;

                    default:

                        Console.WriteLine("Opção Inválida, tente novamente!!");
                        break;
                }
            }
            while (Forma != 4);
        }
    }
}
