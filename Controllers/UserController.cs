using Microsoft.AspNetCore.Mvc;
using Oracle.ManagedDataAccess.Client;
using PetshopWebApp.Models;
using PetshopWebApp.Services;

namespace PetshopWebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : Controller, ControllerDTO<User>
    {
        private readonly UserService _service;

        public UserController(UserService service)
        {
            _service = service;
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

        [HttpPost]
        public IActionResult Create([FromBody] User newModel)
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

        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] User newModel)
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

    }
}
