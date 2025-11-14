namespace Produto_Estoque.Menu;

internal class RemoverProduto : TituloOpcao
{
    public override void Executar(Dictionary<string, Produto> estoque)
    {
        base.Executar(estoque);
        ExibirTituloDaOpcao("Remover Produto do Estoque");
        if (estoque.Count == 0)
        {
            Console.WriteLine("O estoque está vazio! Adiciona produtos para gerenciarlos :)");
        }
        else
        {
            foreach (var produto in estoque.Keys)
            {
                Console.WriteLine($"Item: {produto}\n");
            }
            Console.Write("Digite o nome do produto que deseja remover: ");
            string nomeProduto = Console.ReadLine()!;
            if (estoque.ContainsKey(nomeProduto))
            {
                estoque.Remove(nomeProduto);
                Console.WriteLine($"\nProduto '{nomeProduto}' removido com sucesso do estoque!");
            }
            else
            {
                Console.WriteLine($"\nProduto '{nomeProduto}' não encontrado no estoque.");
            }
        }
    }
}
