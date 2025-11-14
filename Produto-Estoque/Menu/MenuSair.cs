using System.ComponentModel.DataAnnotations.Schema;

namespace Produto_Estoque.Menu;

internal class MenuSair : TituloOpcao
{

    public override void Executar(Dictionary<string, Produto> estoque)
    {
        base.Executar(estoque);
        ExibirLogo logo = new();
        logo.Executar();
        Console.WriteLine("\nObrigado por usar o sistema de gerenciamento de estoque. Até logo!");
        Environment.Exit(0);
    }



}
