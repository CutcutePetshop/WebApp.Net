namespace PetshopWebApp.Models;

public class Peixe : Animal
{
    public Peixe(string nome, string descricao, string raca, Petshop petshop, Sexo sexo, DateTime dataNascimento, Porte porte, float peso, string imgPath) : base(nome, descricao, "Passaro", raca, petshop, sexo, dataNascimento, porte, peso, imgPath)
    {
    }

    public override void EmitirSom()
    {
        Console.WriteLine("Peixe não faz barulho, é quietinho...");
    }
}