namespace PetshopWebApp.Models;

public class Produto
{
    
    public Produto(string nome, string descricao, decimal preco)
    {
        Nome = nome;
        Descricao = descricao;
        Preco = preco;
    }
    
    private int Id { get; set; }
    
    private string Nome { get; set; }
    
    private string Descricao { get; set; }

    private decimal Preco { get; set; }
    
    private List<Avaliacao>? Avaliacoes { get; set; }
}