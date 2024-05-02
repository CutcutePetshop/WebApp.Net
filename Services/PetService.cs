using Microsoft.EntityFrameworkCore;
using PetshopWebApp.Models;
using PetshopWebApp.Persistence;

namespace PetshopWebApp.Services
{
    public class PetService : ServiceDTO<Pet>
    {
        private readonly OracleDbContext _context;

        public PetService(OracleDbContext context)
        {
            _context = context;
        }

        public bool Create(Pet model)
        {
            try
            {
                _context.Pets.Add(model);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocorreu um erro ao tentar criar pet");
                return false;
            }
        }

        public bool Delete(int id)
        {
            try
            {
                var model = GetById(id);

                _context.Pets.Remove(model);

                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocorreu um erro ao tentar deletar pet");
                return false;
            }
        }

        public List<Pet> GetAll()
        {
            try
            {
                return _context.Pets.ToList();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocorreu um erro ao tentar encontrar pets");
                return null;
            }
        }

        public Pet GetById(int id)
        {
            try
            {
                return _context.Pets.FirstOrDefault(p => p.IdPet == id);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocorreu um erro ao tentar encontrar pet por id");
                return null;
            }
        }

        public bool Update(int id, Pet newModel)
        {
            try
            {
                var found = GetById(id);

                found.Name = newModel.Name;
                found.Description = newModel.Description;
                found.Species = newModel.Species;
                found.Race = newModel.Race;
                found.Birthday = newModel.Birthday;
                found.ImagePath = newModel.ImagePath;

                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocorreu um erro ao tentar atualizar as informações do pet");
                return false;
            }
        }
    }
}
