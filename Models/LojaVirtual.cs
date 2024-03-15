namespace PetshopWebApp.Models;

public class LojaVirtual : ILojaVirtual
{
    public LojaVirtual(string nome)
    {
        Nome = nome;
        DataCriacao = DateTime.Today;
        Market = new List<Produto>();
    }

    private int Id { get; set; }
    
    public string Nome { get; set; }

    protected DateTime DataCriacao { get; set; }

    internal List<Produto> Market { get; set; }

    public void AdcionarProduto(Produto produto)
    {
        Market.Add(produto);
    }

    public void EditarProduto()
    {
        throw new NotImplementedException();
    }
    
    public void RemoverProduto(int idProduto)
    {
        Market = Market.Where(produto => produto.Id != idProduto).ToList();
    }
}