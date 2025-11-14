class Produto
{
    public Produto(string nome, double preco, int quantidade, int id)
    {
        Nome = nome;
        Preco = preco;
        Quantidade = quantidade;
        Id = id;
    }

    public string Nome { get; }
    public double Preco { get; }
    public int Id { get; }
    public int Quantidade { get; set; }

}