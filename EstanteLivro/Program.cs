using EstanteLivro;

//Livro l = new("Senhor dos Anéis", "J. R. R. Tolkien", DateOnly.Parse("03/11/2001"), "Saraiva", 1, "1234567", 500);

Livro[] estante = new Livro[10];
int indice = 0, op = 0;

int Menu()
{
    Console.WriteLine("1 - Cadastrar Livro");
    Console.WriteLine("2 - Imprimir Estante");
    Console.WriteLine("3 - Imprimir Livro Especifico");
    Console.WriteLine("4 - Sair");
    Console.WriteLine("Escolha sua opção: ");
    return int.Parse(Console.ReadLine());
}


Livro CadastrarLivro()
{
    string titulo, autor, editora, isbn;
    int edicao, paginas;
    DateOnly lancamento;

    do
    {
        Console.WriteLine("Informe o titulo do livro: ");
        titulo = Console.ReadLine();
        Console.WriteLine("Informe o autor do livro: ");
        autor = Console.ReadLine();
        Console.WriteLine("Informe a data de lançamento: ");
        lancamento = DateOnly.Parse(Console.ReadLine());
        Console.WriteLine("Informe a editora: ");
        editora = Console.ReadLine();
        Console.WriteLine("Informe a edição: ");
        edicao = int.Parse(Console.ReadLine());
        Console.WriteLine("Informe o ISBN: ");
        isbn = Console.ReadLine();
        Console.WriteLine("Informe a quantidade de páginas: ");
        paginas = int.Parse(Console.ReadLine());

        if (edicao <= 0 || paginas < 1)
        {
            Console.WriteLine("valores impróprios adcioandos");
        }
        else
        {
            Console.WriteLine("livro adicionado com sucesso");
        }

    } while (edicao <= 0 || paginas < 1);



    return new(titulo, autor, lancamento, editora, edicao, isbn, paginas);

}
void AdicionarLivroNaEstante()
{
    do
    {
        if (indice < 10)
        {
            Livro l = CadastrarLivro();
            estante[indice] = l;
            indice++;
            Console.WriteLine("Deseja cadastrar um novo livro?");
            Console.WriteLine("0 - caso não");
            op = int.Parse(Console.ReadLine());

            if (op != 0)
            {
                Console.WriteLine("Cadastrando outro livro.");

            }
            else
            {

                Console.WriteLine("Até mais.");

            }
        }
        else
        {
            Console.WriteLine("Estante cheia.");

        }


    } while (op != 0 && indice < 10);
}
void ImprimirEstante()
{
    for (int i = 0; i < indice; i++)
        estante[i].ImprimirLivro();
}

void BuscarLivro(int i)
{
    if (i < indice)
    {
        estante[i].ImprimirLivro();
    }
    else
    {
        Console.WriteLine("Não existe livre nesse local");
    }
}

do
{
    switch (Menu())
    {
        case 1:
            AdicionarLivroNaEstante();
            break;
        case 2:
            ImprimirEstante();
            break;
        case 3:
            Console.Write("Informe o indice do livro: ");
            BuscarLivro(int.Parse(Console.ReadLine()));
            break;
        case 4:
            Console.WriteLine("Hasta la vista, baby!");
            Environment.Exit(0);
            break;
        default:
            Console.WriteLine("Opção Inválida!");
            break;
    }
} while (true);

