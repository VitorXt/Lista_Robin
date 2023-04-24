using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atv9
{
    public class Livros
    {
        public string Nome_livro { get; set; }
        public string genero_livro { get; set; }
        public string idioma { get; set; }
        public string edicao { get; set; }
        public string data_lancamento { get; set; }
        public Autor autor { get; set; }

    }
}
