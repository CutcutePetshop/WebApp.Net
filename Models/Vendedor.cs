namespace PetshopWebApp.Models;

public class Vendedor : Usuario, IVendedor
{
    public Vendedor(string nome, string senha, string email, string descricao, string telefoneCelular, string cpf, DateTime dataNascimento, Genero genero, string imgPath) : base(nome, senha, email, descricao, telefoneCelular, cpf, dataNascimento, genero, imgPath)
    {
    }

    public void AdcionarProduto()
    {
        throw new NotImplementedException();
    }

    public void EditarProduto()
    {
        throw new NotImplementedException();
    }

    public void RemoverProduto()
    {
        throw new NotImplementedException();
    }

    public void Vender()
    {
        throw new NotImplementedException();
    }
}