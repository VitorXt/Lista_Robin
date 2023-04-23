using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atv6
{
    public class Impressora
    {
        public int qtdeCopia = 1;
        private readonly Documento _documento;

        public Impressora(Documento documento)
        {
            _documento = documento;
        }
        public void Imprimir()
        {
            for (int i = 0; i < qtdeCopia; i++)
            {
                Console.WriteLine(_documento.texto);
            }
        }
    }
}