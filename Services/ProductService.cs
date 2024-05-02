using Microsoft.EntityFrameworkCore;
using PetshopWebApp.Models;
using PetshopWebApp.Persistence;

namespace PetshopWebApp.Services
{
    public class ProductService : ServiceDTO<Product>
    {
        private readonly OracleDbContext _context;

        public ProductService(OracleDbContext context)
        {
            _context = context;
        }

        public bool Create(Product model)
        {
            try
            {
                _context.Products.Add(model);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocorreu um erro ao tentar criar produto");
                return false;
            }
        }

        public bool Delete(int id)
        {
            try
            {
                var model = GetById(id);

                _context.Products.Remove(model);

                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocorreu um erro ao tentar deletar produto");
                return false;
            }
        }

        public List<Product> GetAll()
        {
            try
            {
                return _context.Products.ToList();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocorreu um erro ao tentar encontrar produtos");
                return null;
            }
        }

        public Product GetById(int id)
        {
            try
            {
                return _context.Products.FirstOrDefault(p => p.IdProduct == id);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocorreu um erro ao tentar encontrar produto por id");
                return null;
            }
        }

        public bool Update(int id, Product newModel)
        {
            try
            {
                var found = GetById(id);

                found.Name = newModel.Name;
                found.Description = newModel.Description;
                found.Price = newModel.Price;

                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocorreu um erro ao tentar atualizar as informações de produto");
                return false;
            }
        }
    }
}
