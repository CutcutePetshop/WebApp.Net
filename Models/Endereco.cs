namespace PetshopWebApp.Models;

public class Endereco
{

    public Endereco(int cep)
    {
        CEP = cep;
    }

    public Endereco(string uf, string cidade, string bairro, string rua, int numResid)
    {
        UF = uf;
        Cidade = cidade;
        Bairro = bairro;
        Rua = rua;
        NumResid = numResid;
    }

    private int CEP { get; set; }
    
    private string UF { get; set; }
    
    private string Cidade { get; set; }
    
    private string Bairro { get; set; }
    
    private string Rua { get; set; }
    
    private int NumResid { get; set; }

}