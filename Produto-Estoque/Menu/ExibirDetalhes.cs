namespace Produto_Estoque.Menu;

internal class ExibirDetalhes : TituloOpcao
{
    public override void Executar(Dictionary<string, Produto> estoque)
    {
        base.Executar(estoque);
        ExibirTituloDaOpcao("Gerenciamento Estoque");
        if (estoque.Count == 0)
        {
            Console.WriteLine("O estoque está vazio! Adiciona produtos para gerenciarlos :)");
        }
        else{ 
            Console.WriteLine("Digite 'A' para mostrar produtos com mais quantidade");
        Console.WriteLine("Digite 'B' para mostrar produtos com menos quantidade\n");
        string escolha = Console.ReadLine()!;
        int contador = 1;
        if (escolha == "A")
        {
            Console.WriteLine("\nProdutos com mais quantidade");
            var listaOrganizadaMaior = estoque.Values.OrderByDescending(p => p.Quantidade);

            foreach (var produto in listaOrganizadaMaior)
            {
                Console.WriteLine($"{contador}- Item: {produto.Nome} - {produto.Quantidade} unds.");
                contador++;
            }
        } else if (escolha == "B")
        {
            Console.WriteLine("\nProdutos com menos quantidade");
            var listaOrganizadaMenor = estoque.Values.OrderBy(p => p.Quantidade);
            foreach (var produto in listaOrganizadaMenor)
            {
                Console.WriteLine($"{contador}- Item: {produto.Nome} - {produto.Quantidade} unds.");
                contador++;
            }
        }
        else
        {
            Console.WriteLine("Opção Invalida");
        }
    } }
    }

