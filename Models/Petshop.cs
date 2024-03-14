namespace PetshopWebApp.Models;

public class Petshop
{
    
    public Petshop(string nome, int cep)
    {
        Nome = nome;
        CEP = cep;
        Animais = new List<Animal>();
        Avaliacoes = new List<Avaliacao>();
    }
    
    private int Id { get; set; }
    
    public string Nome { get; set; }

    protected int CEP { get; set; }
    
    private List<Animal> Animais { get; set; }
    
    private List<Avaliacao> Avaliacoes { get; set; }
}