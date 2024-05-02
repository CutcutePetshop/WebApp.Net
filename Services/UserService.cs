using Microsoft.EntityFrameworkCore;
using PetshopWebApp.Models;
using PetshopWebApp.Persistence;

namespace PetshopWebApp.Services
{
    public class UserService : ServiceDTO<User>
    {
        private readonly OracleDbContext _context;

        public UserService(OracleDbContext context)
        {
            _context = context;
        }

        public bool Create(User model)
        {
            try
            {
                _context.Users.Add(model);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocorreu um erro ao tentar criar usuario");
                return false;
            }
        }

        public bool Delete(int id)
        {
            try
            {
                var model = GetById(id);

                _context.Users.Remove(model);

                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocorreu um erro ao tentar deletar usuario");
                return false;
            }
        }

        public List<User> GetAll()
        {
            try
            {
                return _context.Users.ToList();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocorreu um erro ao tentar encontrar usuarios");
                return null;
            }
        }

        public User GetById(int id)
        {
            try
            {
                return _context.Users.FirstOrDefault(u => u.IdUser == id);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocorreu um erro ao tentar encontrar usuario por id");
                return null;
            }
        }

        public bool Update(int id, User newModel)
        {
            try
            {
                var found = GetById(id);

                found.Name = newModel.Name;
                found.Email = newModel.Email;
                found.Password = newModel.Password;
                found.Cpf = newModel.Cpf;
                found.Description = newModel.Description;
                found.Birthday = newModel.Birthday;
                found.PhoneNumber = newModel.PhoneNumber;
                found.Gender = newModel.Gender;
                found.ImagePath = newModel.ImagePath;

                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocorreu um erro ao tentar atualizar as informações de usuario");
                return false;
            }
        }
    }
}
