using Atv5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atv5
{
    public class Circunferencia : Forma
    {
        public double raio;
        public override void CalcularArea()
        {
            Area = 3.14 * Math.Pow(raio, 2);
            Console.WriteLine($"A área da Circunferência é: {Area}");
        }

        public override void CalcularPerimero()
        {
            Perimetro = (int)(2 * 3.14 * raio);
            Console.WriteLine($"O perímetro da Circunferência é: {Perimetro}");
        }
    }
}
