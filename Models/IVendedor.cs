namespace PetshopWebApp.Models;

public interface IVendedor
{

    void AdcionarProduto();

    void EditarProduto();
    
    void RemoverProduto();

    void Vender(); // Eu não sei como isso funcionaria, mas parece fazer sentido

}