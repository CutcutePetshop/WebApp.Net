namespace PetshopWebApp.Models;

public class Gato : Animal
{
    public Gato(string nome, string descricao, string especie, string raca, Petshop petshop, Sexo sexo, DateTime dataNascimento, Porte porte, float peso, string imgPath) : base(nome, descricao, especie, raca, petshop, sexo, dataNascimento, porte, peso, imgPath)
    {
    }

    public override void EmitirSom()
    {
        base.EmitirSom();
    }
}