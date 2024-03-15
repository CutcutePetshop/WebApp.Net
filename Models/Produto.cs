namespace PetshopWebApp.Models;

public class Produto
{
    
    public Produto(string nome, string descricao, decimal preco, Vendedor vendedor)
    {
        Nome = nome;
        Descricao = descricao;
        Preco = preco;
        Vendedor = vendedor;
        Avaliacoes = new List<Avaliacao>();
    }
    
    public int Id { get; set; }
    
    private string Nome { get; set; }
    
    private string Descricao { get; set; }

    private decimal Preco { get; set; }
    
    private Vendedor Vendedor { get; set; }
    
    private List<Avaliacao> Avaliacoes { get; set; }

    private int GetAvaliacaoGeral()
    {
        // coletar a qtd de estrelas de cada Avaliacao em Avaliacoes
        int totalEstrelas = Avaliacoes.Sum(avaliacao => avaliacao.QtdEstrelas);

        return totalEstrelas / Avaliacoes.Count;
    }
}