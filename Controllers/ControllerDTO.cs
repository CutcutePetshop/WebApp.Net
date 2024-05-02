using Microsoft.AspNetCore.Mvc;
using PetshopWebApp.Services;

namespace PetshopWebApp.Controllers
{
    public interface ControllerDTO<Model>
    {
        IActionResult GetAll();

        IActionResult GetById(int id);

        IActionResult Create([FromBody] Model newModel);

        IActionResult Update(int id, [FromBody] Model newModel);

        IActionResult Delete(int id);
    }
}
