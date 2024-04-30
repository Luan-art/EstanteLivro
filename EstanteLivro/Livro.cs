using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstanteLivro
{
    internal class Livro
    {
        string Titulo;
        string[] Autor;
        DateOnly Lancamento;
        string Editora;
        int Edicao;
        string ISBN;
        int Paginas;

        public Livro(string titulo, string[] autor, DateOnly lancamento, string editora, int edicao, string iSBN, int paginas)
        {
            Titulo = titulo;
            Autor = autor;
            Lancamento = lancamento;
            Editora = editora;
            Edicao = edicao;
            ISBN = iSBN;
            Paginas = paginas;
        }

        public void ImprimirLivro(int qtdAutor)
        {
            Console.WriteLine("\n\n>>> INFORMAÇÕES DO LIVRO <<<");
            Console.WriteLine("Titulo: "+this.Titulo);
            Console.WriteLine("Autores: ");
            for(int i = 0; i < Autor.Length; i++)
            {
                if(Autor != null)
                {
                Console.WriteLine("Autor: " + this.Autor[i]);
                }

            }
            Console.WriteLine("Data de Lançamento: "+this.Lancamento);
            Console.WriteLine("Editora: "+this.Editora);
            Console.WriteLine("Ediçao: "+this.Edicao);
            Console.WriteLine("ISBN: "+this.ISBN);
            Console.WriteLine("Quantidade de Páginas: "+this.Paginas);
        }
    }
}
