namespace PetshopWebApp.Models;

public interface IUsuario
{
    void Cadastrar();
    
    void Logar();

    void Sair();

    void ExcluirConta();

    // Lista de Favoritos
    
    void Favoritar();

    void Desfavoritar();

    // Carrinho de compras dos Produtos
    
    void AdcionarNoCarrinho();

    void EditarCarrinho();

    void RemoverDoCarrinho();
    
    void Comprar();

    // Avaliação de Produto
    
    void AdcionarAvaliacao();

    void EditarAvaliacao();
    
    void RemoverAvaliacao();
    
    // Contato com Vendedor

    void EnviarMensagem();

    void EditarMensagem();

    void ExcluirMensagem();
}