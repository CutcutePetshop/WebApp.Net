namespace PetshopWebApp.Models;

public class Petshop
{
    public Petshop(int id, string nome, int cep)
    {
        Id = id;
        Nome = nome;
        CEP = cep;
        Animais = new List<Animal>();
        Avaliacoes = new List<Avaliacao>();
    }
    
    public Petshop(string nome, int cep)
    {
        Nome = nome;
        CEP = cep;
        Animais = new List<Animal>();
        Avaliacoes = new List<Avaliacao>();
    }
    
    public int Id { get; set; }
    
    public string Nome { get; set; }

    public int CEP { get; set; }
    
    public List<Animal> Animais { get; set; }
    
    public List<Avaliacao> Avaliacoes { get; set; }
}