using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atv9
{
    public class Biblioteca
    {
        List<Livros> Lista_Livros = new List<Livros>();

        public void Adicionar_livro(Livros livro)
        {
            Lista_Livros.Add(livro);
        }
        public void Pesquisar_Titulo(string titulo_Livro)
        {
            foreach (var item in Lista_Livros)
            {
                if (item.Nome_livro == titulo_Livro)
                {
                    Console.WriteLine("O titulo existe ");
                    Listar_Livros();
                }
                else
                {
                    Console.WriteLine("não existe");
                }
            }
        }
        public void Listar_Livros()
        {
            foreach (var item in Lista_Livros)
            {
                Console.WriteLine($"Nome Livro: {item.Nome_livro}");
                Console.WriteLine($"Nome autor: {item.autor.Nome}");
                Console.WriteLine($"Edição: {item.edicao}");
                Console.WriteLine($"Genero do Livro: {item.genero_livro}");
            }
        }
    }
}
