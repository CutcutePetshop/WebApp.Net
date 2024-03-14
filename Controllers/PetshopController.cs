using PetshopWebApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace PetshopWebApp.Controllers
{
    public class PetshopController : Controller
    {
        
        public IActionResult ListAll()
        {
            List<Petshop> listPetshops = new List<Petshop>();
            listPetshops.Add(new Petshop("Fofurinhas Curitiba", 12341234));
            listPetshops.Add(new Petshop("Fofurinhas OZ", 43214321));
            listPetshops.Add(new Petshop("Fofurinhas SP", 99567856));
        
            return View(listPetshops);
        }
        
    }
    
}

