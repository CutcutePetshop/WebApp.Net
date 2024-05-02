using PetshopWebApp.Models;
using PetshopWebApp.Persistence;

namespace PetshopWebApp.Services
{
    public class PetshopService : ServiceDTO<Petshop>
    {
        private readonly OracleDbContext _context;

        public PetshopService(OracleDbContext context)
        {
            _context = context;
        }

        public bool Create(Petshop model)
        {
            try
            {
                _context.PetShops.Add(model);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocorreu um erro ao tentar criar petshop");
                return false;
            }
        }

        public bool Delete(int id)
        {
            try
            {
                var model = GetById(id);

                _context.PetShops.Remove(model);

                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocorreu um erro ao tentar deletar petshop");
                return false;
            }
        }

        public List<Petshop> GetAll()
        {
            try
            {
                return _context.PetShops.ToList();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocorreu um erro ao tentar encontrar petshops");
                return null;
            }
        }

        public Petshop GetById(int id)
        {
            try
            {
                return _context.PetShops.FirstOrDefault(ps => ps.IdPetshop == id);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocorreu um erro ao tentar encontrar petshop por id");
                return null;
            }
        }

        public bool Update(int id, Petshop newModel)
        {
            try
            {
                var found = GetById(id);

                found.Name = newModel.Name;
                found.Cep = newModel.Cep;

                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocorreu um erro ao tentar atualizar as informações de petshop");
                return false;
            }
        }
    }
}
