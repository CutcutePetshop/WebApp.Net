namespace PetshopWebApp.Services
{
    public interface ServiceDTO<Model>
    {

        public List<Model> GetAll();

        public Model GetById(int id);

        public bool Create(Model model);

        public bool Update(int id, Model newModel);

        public bool Delete(int id);
    }
}
