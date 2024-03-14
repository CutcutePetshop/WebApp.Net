namespace PetshopWebApp.Models;

public class Animal : IAnimal
{

    public Animal(string nome, string descricao, string especie, string raca, Petshop petshop, Sexo sexo, DateTime dataNascimento, Porte porte, float peso, string imgPath)
    {

        if (string.IsNullOrWhiteSpace(nome) || string.IsNullOrWhiteSpace(especie) || string.IsNullOrWhiteSpace(raca))
        {
            throw new ArgumentNullException("Há um campo vazio");
        }
        
        Nome = nome;
        Descricao = descricao;
        Especie = especie;
        Raca = raca;
        Petshop = petshop;
        Sexo = sexo;
        DataNascimento = dataNascimento;
        Porte = porte;
        Peso = peso;
        ImgPath = imgPath;
    }

    private int Id { get; set; }
    
    public string Nome { get; set; } // Não pode ser vazia
    
    public string Descricao { get; set; } // Pode ser vazia
    
    public string Especie { get; set; } // Gato, Cachorro, Passaro, Peixe, etc.
    
    public string Raca { get; set; } // Raça do animal

    public Petshop Petshop { get; set; } // Local do animal
    
    public Sexo Sexo { get; set; } // Macho, Femea
    
    public DateTime DataNascimento { get; set; }

    public Porte Porte { get; set; } // Pequeno, médio, grande
    
    public float Peso{ get; set; }
    
    public string ImgPath { get; set; } // Caminho para uma foto do animal
    public virtual void EmitirSom()
    {
        throw new NotImplementedException();
    }
}

public enum Porte
{
    Pequeno,
    Medio,
    Grande
}

public enum Sexo
{
    Macho,
    Femea
}