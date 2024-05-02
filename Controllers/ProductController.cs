using Microsoft.AspNetCore.Mvc;
using PetshopWebApp.Models;
using PetshopWebApp.Services;

namespace PetshopWebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : Controller, ControllerDTO<Product>
    {
        private readonly ProductService _service;

        public ProductController(ProductService service)
        {
            _service = service;
        }

        [HttpPost]
        public IActionResult Create([FromBody] Product newModel)
        {
            if (newModel == null)
            {
                return BadRequest();
            }
            var success = _service.Create(newModel);

            if (!success)
            {
                return BadRequest();
            }
            return Ok(newModel);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var model = _service.GetById(id);

            if (model == null)
            {
                return NotFound();
            }

            var success = _service.Delete(id);

            if (!success)
            {
                return BadRequest();
            }

            return NoContent();
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var model = _service.GetAll();
            if (model == null)
            {
                return NotFound();
            }
            return Ok(model);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var model = _service.GetById(id);
            if (model == null)
            {
                return NotFound();
            }
            return Ok(model);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] Product newModel)
        {
            if (newModel == null)
            {
                return BadRequest();
            }

            var success = _service.Update(id, newModel);

            if (!success)
            {
                return NotFound();
            }

            return NoContent();
        }
    }
}
