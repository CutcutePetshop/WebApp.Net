namespace PetshopWebApp.Models;

public class Animal
{

    public Animal(string nome, string descricao, string especie, string raca, Loja loja, Sexo sexo, DateTime dataNascimento, Porte porte, float peso, string imgPath)
    {

        if (string.IsNullOrWhiteSpace(nome) || string.IsNullOrWhiteSpace(especie) || string.IsNullOrWhiteSpace(raca))
        {
            throw new ArgumentNullException("Há um campo vazio");
        }
        
        Nome = nome;
        Descricao = descricao;
        Especie = especie;
        Raca = raca;
        Loja = loja;
        Sexo = sexo;
        DataNascimento = dataNascimento;
        Porte = porte;
        Peso = peso;
        ImgPath = imgPath;
    }

    private int Id { get; set; }
    
    private string Nome { get; set; } // Não pode ser vazia
    
    private string Descricao { get; set; } // Pode ser vazia
    
    private string Especie { get; set; } // Gato, Cachorro, Passaro, Peixe, etc.
    
    private string Raca { get; set; } // Raça do animal

    private Loja Loja { get; set; } // Local do animal
    
    private Sexo Sexo { get; set; } // Macho, Femea
    
    private DateTime DataNascimento { get; set; }

    private Porte Porte { get; set; } // Pequeno, médio, grande
    
    private float Peso{ get; set; }
    
    private string ImgPath { get; set; } // Caminho para uma foto do animal
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