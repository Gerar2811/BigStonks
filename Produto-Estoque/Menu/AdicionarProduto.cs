namespace Produto_Estoque.Menu;

internal class AdicionarProduto: TituloOpcao
{
    public override 
        void Executar(Dictionary<string, Produto> estoque )
    {
        base.Executar( estoque );
        ExibirTituloDaOpcao("Adicionar Produto ao Estoque");
        Console.Write("Digite o nome do produto: ");
        string nome = Console.ReadLine()!;

        if (estoque.ContainsKey(nome))
        {
            Console.WriteLine($"O produto {nome} ja esta registrado!");
            Console.WriteLine($"Gostaria de acrescentar mais unidades so item {nome}");
            Console.WriteLine("\nDigite 'S' ou 'N' para voltar no menu principal");
            string resposta = Console.ReadLine()!;

            var produto = estoque[nome];
            if (resposta == "S")
            {
                base.Executar(estoque);
                ExibirTituloDaOpcao("Adicionar Produto ao Estoque");
                Console.WriteLine($"Atualmente o item {produto.Nome} tem {produto.Quantidade} unds.");
                Console.WriteLine("Quer acrescentar quantas unidades? ");
                int saldoExtra = int.Parse(Console.ReadLine()!);

                Console.WriteLine($"{saldoExtra}");
                Console.WriteLine($"O saldo do item {produto.Nome} foi atualizado com {produto.Quantidade+=saldoExtra}");
            }else if(resposta == "N")
            {
                return;
            }

        }
        else
        {
            Console.Write("Digite preço do produto: ");
            double preco = double.Parse(Console.ReadLine()!);

            Console.Write("Digite a quantidade para acrescentar no estoque: ");
            int quantidade = int.Parse(Console.ReadLine()!);

            Console.Write("Digite o ID do produto: ");
            int id = int.Parse(Console.ReadLine()!);

            Produto novoProduto = new Produto(nome, preco, id, quantidade);
            string nomeProdutoNovo = nome;
            estoque.Add(nomeProdutoNovo, novoProduto);
            Console.WriteLine($"\nO produto : {novoProduto.Nome} foi guardado no estoque");
        }

    }
}
