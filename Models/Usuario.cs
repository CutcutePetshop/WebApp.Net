namespace PetshopWebApp.Models;

public class Usuario : IUsuario
{
    
    public Usuario(string nome, string senha, string email, string descricao, string telefone, string cpf, DateTime dataNascimento, Genero genero, string imgPath)
    {
        if (string.IsNullOrWhiteSpace(nome) || string.IsNullOrWhiteSpace(senha) || string.IsNullOrWhiteSpace(cpf))
        {
            throw new ArgumentNullException("Há um campo vazio");
        }
        
        Nome = nome;
        Senha = senha;
        Email = email;
        Descricao = descricao;
        Telefone = telefone;
        CPF = cpf;
        DataNascimento = dataNascimento;
        Genero = genero;
        ImgPath = string.IsNullOrWhiteSpace(imgPath) ? "favicon.ico" : imgPath;
    }
    
    private int Id { get; set; }
    
    public string Nome { get; set; }
    
    private string Senha { get; set; }
    
    private string Email {get; set; }
    
    private string Descricao { get; set; }
    
    private string Telefone { get; set; }
    
    private string CPF { get; set; }
    
    private DateTime DataNascimento { get; set; }
    
    private Genero Genero { get; set; }
    
    private string ImgPath { get; set; }
    public void Cadastrar()
    {
        throw new NotImplementedException();
    }

    public void Logar()
    {
        throw new NotImplementedException();
    }

    public void Sair()
    {
        throw new NotImplementedException();
    }

    public void ExcluirConta()
    {
        throw new NotImplementedException();
    }

    public void Favoritar()
    {
        throw new NotImplementedException();
    }

    public void Desfavoritar()
    {
        throw new NotImplementedException();
    }

    public void AdcionarNoCarrinho()
    {
        throw new NotImplementedException();
    }

    public void EditarCarrinho()
    {
        throw new NotImplementedException();
    }

    public void RemoverDoCarrinho()
    {
        throw new NotImplementedException();
    }

    public void Comprar()
    {
        throw new NotImplementedException();
    }

    public void AdcionarAvaliacao()
    {
        throw new NotImplementedException();
    }

    public void EditarAvaliacao()
    {
        throw new NotImplementedException();
    }

    public void RemoverAvaliacao()
    {
        throw new NotImplementedException();
    }

    public void EnviarMensagem()
    {
        throw new NotImplementedException();
    }

    public void EditarMensagem()
    {
        throw new NotImplementedException();
    }

    public void ExcluirMensagem()
    {
        throw new NotImplementedException();
    }
}

public enum Genero
{
    Masculino,
    Feminino
}