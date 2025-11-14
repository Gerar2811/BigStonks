using System.Xml;

namespace Produto_Estoque.Menu;

internal class DiminuirQuantidadeEstoque : TituloOpcao
{
    public override void Executar(Dictionary<string, Produto> estoque)
    {
        base.Executar(estoque);
        ExibirTituloDaOpcao("Diminução Estoque");
        if (estoque.Count == 0)
        {
            Console.WriteLine("O estoque está vazio! Adiciona produtos para gerenciarlos :)");
        }
        else
        {
            int contador = 1;
            foreach (var item in estoque)
            {
                Console.WriteLine($"{contador}- Produto: {item.Value.Nome} - {item.Value.Quantidade} unds.");
                contador++;
            }
            Console.Write("\nEscolha um item para diminuir o saldo ");
            string produto = Console.ReadLine()!;

            if (estoque.ContainsKey(produto))
            {
                Console.WriteLine("\nQuantas unidades deseja diminuir?");
                int saldo = int.Parse(Console.ReadLine()!);
                var produtoEscolhdo = estoque.FirstOrDefault(p => p.Value.Nome == produto);
                if (saldo > produtoEscolhdo.Value.Quantidade)
                {
                    Console.WriteLine("\nNão é posivel tirar o saldo devido que é maior do que ja tem no estoque :(");

                }
                else if (saldo == 0)
                {
                    Console.WriteLine("\nNão é posivel tirar 0 unidades.");
                }
                else
                {
                    Console.WriteLine("\nProcceso feito com Sucesso! :)");
                    produtoEscolhdo.Value.Quantidade -= saldo;
                    if (produtoEscolhdo.Value.Quantidade == 0)
                    {
                        Console.WriteLine($"\nO item {produtoEscolhdo.Value.Nome} ficou sem unidades");
                        Console.Write("Deseja excluir do estoque? (S/N)");
                        string resposta = Console.ReadLine()!;
                        if (resposta == "S")
                        {
                            estoque.Remove(produto);
                            Console.WriteLine("Produto excluido com sucesso! :)");
                        }
                        else if (resposta == "N")
                        {
                            Console.WriteLine($"Item {produtoEscolhdo.Value.Nome} ficou sem unidades.");
                            Console.WriteLine("Não esqueça de dar saldo depois!");
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("Produto não encontrado!");
            }

        }
    }
}
