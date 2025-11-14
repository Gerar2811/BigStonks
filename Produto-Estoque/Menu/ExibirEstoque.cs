namespace Produto_Estoque.Menu;

internal class ExibirEstoque : TituloOpcao
{
    public override void Executar(Dictionary<string, Produto> estoque)
    { 
        Console.Clear();
        ExibirTituloDaOpcao("Estoque");
        if (estoque.Count == 0)
        {
            Console.WriteLine("O estoque está vazio! Adiciona produtos para gerenciarlos:)\n");
            return;
        }
        else
        {
            foreach (var produto in estoque.Values)
            {
                Console.WriteLine($"Nome: {produto.Nome} - {produto.Preco}R$ - {produto.Quantidade} unds. - ID0{produto.Id}\n");
            }
        }
    }
}

