using PetshopWebApp.Models;
using PetshopWebApp.Persistence;

namespace PetshopWebApp.Services
{
    public class ReviewService : ServiceDTO<Review>
    {
        private readonly OracleDbContext _context;

        public ReviewService(OracleDbContext context)
        {
            _context = context;
        }
        public bool Create(Review model)
        {
            try
            {
                _context.Reviews.Add(model);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocorreu um erro ao tentar criar review");
                return false;
            }
        }

        public bool Delete(int id)
        {
            try
            {
                var model = GetById(id);

                _context.Reviews.Remove(model);

                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocorreu um erro ao tentar deletar review");
                return false;
            }
        }

        public List<Review> GetAll()
        {
            try
            {
                return _context.Reviews.ToList();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocorreu um erro ao tentar encontrar reviews");
                return null;
            }
        }

        public Review GetById(int id)
        {
            try
            {
                return _context.Reviews.FirstOrDefault(r => r.IdReview == id);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocorreu um erro ao tentar encontrar review por id");
                return null;
            }
        }

        public bool Update(int id, Review newModel)
        {
            try
            {
                var found = GetById(id);

                found.Description = newModel.Description;
                found.Stars = newModel.Stars;
                found.DatePublished = newModel.DatePublished;

                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocorreu um erro ao tentar atualizar as informações de review");
                return false;
            }
        }
    }
}
