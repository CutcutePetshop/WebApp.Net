namespace PetshopWebApp.Models;

public class Loja
{
    
    public Loja(string nome, Endereco endereco)
    {
        Nome = nome;
        Endereco = endereco;
    }
    
    private int Id { get; set; }
    
    private string Nome { get; set; }

    private Endereco Endereco { get; set; }
    
    private List<Animal>? Animais { get; set; }

}