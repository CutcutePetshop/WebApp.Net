namespace PetshopWebApp.Models;

public interface ILojaVirtual
{
    
    void AdcionarProduto(Produto produto);

    void EditarProduto();
    
    void RemoverProduto(int idProduto);
    
}