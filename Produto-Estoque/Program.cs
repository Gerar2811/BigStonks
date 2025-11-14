using Produto_Estoque.Menu;

Dictionary<string, Produto> estoque = new();

Dictionary <int, TituloOpcao> opcoes = new();
opcoes.Add(1, new AdicionarProduto());
opcoes.Add(2, new RemoverProduto());
opcoes.Add(3, new DiminuirQuantidadeEstoque());
opcoes.Add(4, new ExibirEstoque());
opcoes.Add(5, new ExibirDetalhes());
opcoes.Add(6, new MenuSair());


ExibirLogo logo = new();
ExibirLogoPrincipal();
ExibirMenu();

void ExibirMenu()
{
    Console.WriteLine("\nDigita sua escolha");
    Console.WriteLine("1 - Adicionar produto ao estoque");
    Console.WriteLine("2 - Remover produto do estoque");
    Console.WriteLine("3 - Remover unidades de estoque");
    Console.WriteLine("4 - Exibir estoque");
    Console.WriteLine("5 - Exibir detalhes");
    Console.WriteLine("6 - Sair");
    Console.Write("Escolha uma opção: ");
    string escolha = Console.ReadLine()!;
    int escolhaNumerica = int.Parse(escolha);

    if (opcoes.ContainsKey(escolhaNumerica))
    {
        TituloOpcao menu = opcoes[escolhaNumerica];
        menu.Executar(estoque);
    }
    else
    { 
        Console.WriteLine("\nOpção invalida.");
        Thread.Sleep(1500);
        Console.Clear();
        logo.Executar();
        ExibirMenu();
    }
    Console.WriteLine("\nPressionar qualquier tecla para voltar no menú");
    Console.ReadKey();
    Thread.Sleep(2000);
    Console.Clear();
    ExibirLogoPrincipal();
    ExibirMenu();

}

void ExibirLogoPrincipal()
{
    Console.WriteLine("\nBem vindo, Como gerenciaremos o estoque hoje?");
    logo.Executar();
}