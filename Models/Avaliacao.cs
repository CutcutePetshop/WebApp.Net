namespace PetshopWebApp.Models;

public class Avaliacao
{
    
    public Avaliacao(Usuario usuario, int qtdEstrelas, string descricao)
    {
        Usuario = usuario;
        QtdEstrelas = qtdEstrelas;
        Descricao = descricao;
    }
    
    private int Id { get; set; }

    public Usuario Usuario { get; set; }
    
    internal int QtdEstrelas { get; set; }
    
    public string Descricao { get; set; }
    
}