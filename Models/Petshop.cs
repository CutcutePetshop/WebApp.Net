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

    public int CEP { get; set; }
    
    public List<Animal> Animais { get; set; }
    
    public List<Avaliacao> Avaliacoes { get; set; }
}