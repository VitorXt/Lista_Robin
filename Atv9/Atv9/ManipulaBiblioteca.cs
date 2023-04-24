using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atv9
{
    public class ManipulaBiblioteca
    {
        Livros _Livro = new Livros();
        Autor _Autor = new Autor();
        Biblioteca _Biblioteca = new Biblioteca();
        public void Cadastrar_Livro()
        {

            PreecherLivro();
            PreencherAutor();

            _Livro.autor = _Autor;

            _Biblioteca.Adicionar_livro(_Livro);
            Console.WriteLine("Qual titulo você deseja procurar");
            string pesquisa = Console.ReadLine();
            _Biblioteca.Pesquisar_Titulo(pesquisa);

        }

        private void PreecherLivro()
        {
            Console.WriteLine("Nome do Livro: ");
            _Livro.Nome_livro = Console.ReadLine();
            Console.WriteLine("Data Lançamento: ");
            _Livro.data_lancamento = Console.ReadLine();
            Console.WriteLine("Idioma:  ");
            _Livro.idioma = Console.ReadLine();
            Console.WriteLine("Edição: ");
            _Livro.edicao = Console.ReadLine();
            Console.WriteLine("Genero do livro: ");
            _Livro.genero_livro = Console.ReadLine();
        }

        private void PreencherAutor()
        {
            Console.WriteLine("Nome do Autor: ");
            _Autor.Nome = Console.ReadLine();
            Console.WriteLine("Data da nascimento: ");
            _Autor.Data_nascimento = Console.ReadLine();
            Console.WriteLine("Pais de origem: ");
            _Autor.Pais_origem = Console.ReadLine();
            Console.WriteLine("Idioma: ");
            _Autor.Idioma_origem = Console.ReadLine();
        }
    }
}
