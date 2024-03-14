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

    private Usuario Usuario { get; set; }
    
    public int QtdEstrelas { get; set; }
    
    private string Descricao { get; set; }
    
}