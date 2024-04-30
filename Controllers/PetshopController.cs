using PetshopWebApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace PetshopWebApp.Controllers
{
    public class PetshopController : Controller
    {

        private List<Animal> ListAnimais()
        {
            List<Animal> listAnimais = new List<Animal>();
            listAnimais.Add(new Cachorro("Dash", "", "vira-lata", null, Sexo.Femea, DateTime.MaxValue, Porte.Pequeno, 10.0F, ""));
            listAnimais.Add(new Cachorro("Dash", "", "vira-lata", null, Sexo.Femea, DateTime.MaxValue, Porte.Pequeno, 10.0F, ""));
            listAnimais.Add(new Cachorro("Dash", "", "vira-lata", null, Sexo.Femea, DateTime.MaxValue, Porte.Pequeno, 10.0F, ""));
            listAnimais.Add(new Cachorro("Dash", "", "vira-lata", null, Sexo.Femea, DateTime.MaxValue, Porte.Pequeno, 10.0F, ""));

            return listAnimais;
        }

        private List<Petshop> ListPetshops()
        {
            List<Petshop> listPetshops = new List<Petshop>();
            listPetshops.Add(new Petshop(1, "CutCute Curitiba", 12341234));
            listPetshops.Add(new Petshop(2, "CutCute OZ", 43214321));
            listPetshops.Add(new Petshop(3, "CutCute SP", 99567856));
            
            listPetshops[0].Animais = ListAnimais();
            listPetshops[1].Animais = ListAnimais();
            listPetshops[2].Animais = ListAnimais();
        
            return listPetshops;
        }
        
        public IActionResult ListAll()
        {
            return View(ListPetshops());
        }

        public IActionResult Details(int id)
        {
            Petshop petshop = ListPetshops().Find(petshop => id == petshop.Id);

            return View(petshop);
        }
        
    }
    
}

