namespace PetshopWebApp.Models;

public class Usuario
{
    
    public Usuario(string nome, string senha, string email, string descricao, string telefoneCelular, string cpf, DateTime dataNascimento, Genero genero, string imgPath)
    {
        if (string.IsNullOrWhiteSpace(nome) || string.IsNullOrWhiteSpace(senha) || string.IsNullOrWhiteSpace(cpf))
        {
            throw new ArgumentNullException("Há um campo vazio");
        }
        
        Nome = nome;
        Senha = senha;
        Email = email;
        Descricao = descricao;
        TelefoneCelular = telefoneCelular;
        CPF = cpf;
        DataNascimento = dataNascimento;
        Genero = genero;
        ImgPath = string.IsNullOrWhiteSpace(imgPath) ? "favicon.ico" : imgPath;
    }
    
    private int Id { get; set; }
    
    private string Nome { get; set; }
    
    private string Senha { get; set; }
    
    private string Email {get; set; }
    
    private string Descricao { get; set; }
    
    private string TelefoneCelular { get; set; }
    
    private string CPF { get; set; }
    
    private DateTime DataNascimento { get; set; }
    
    private Genero Genero { get; set; }
    
    private string ImgPath { get; set; }
}