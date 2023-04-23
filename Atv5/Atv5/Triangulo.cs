using Atv5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atv5
{
    public class Triangulo : Forma
    {
        public double LadoA;
        public double LadoB;
        public double LadoC;

        public override void CalcularArea()
        {
            if (LadoA == LadoB && LadoB == LadoC)
            {
                Area = (LadoA * LadoC) / 2;
                Console.WriteLine($"A área do triângulo é de: {Area}");
            }
            else if (LadoA == LadoB || LadoA == LadoC || LadoB == LadoC)
            {
                double Altura;
                Altura = (LadoA / 2) * Math.Sqrt((2 * Math.Pow(LadoC, 2) - (Math.Pow(LadoA, 2))));
                Area = (LadoC * Altura) / 2;
                Console.WriteLine($"A área do triângulo é de: {Area}");
            }
            else
            {
                double s = (LadoC + LadoB + LadoC) / 2;
                double Altura = (2 / LadoC) * Math.Sqrt(s * (s - LadoA) * (s - LadoB) * (s - LadoC));
                Area = (LadoC * Altura) / 2;
                Console.WriteLine($"A área do triângulo é de: {Area}");
            }
        }
        public override void CalcularPerimero()
        {
            if (LadoA == LadoB && LadoB == LadoC)
            {
                Perimetro = (int)(LadoA * 3);
                Console.WriteLine($"O perímetro do triângulo é de: {Perimetro}");
            }
            else if (LadoA == LadoB || LadoA == LadoC || LadoB == LadoC)
            {
                Perimetro = (int)(2 * LadoA + LadoC);
                Console.WriteLine($"O perímetro do triângulo é de: {Perimetro}");
            }
            else
            {
                Perimetro = (int)(LadoA + LadoB + LadoC);
                Console.WriteLine($"O perímetro do triângulo é de: {Perimetro}");
            }
        }
    }
}
