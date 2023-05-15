using Microsoft.AspNetCore.Mvc;
using TreinamentoWebAPI.Domain;

namespace TreinamentoWebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SuperHeroiController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok();
        }

        [HttpGet("{id:int}")]
        public IActionResult GetById(int id)
        {
            return Ok();
        }

        [HttpPost]
        public IActionResult Post(SuperHeroi superHeroi)
        {
            return Ok();
        }

        [HttpPut("{id:int}")]
        public IActionResult Put(int id, SuperHeroi superHeroi)
        {
            return Ok();
        }

        [HttpDelete("{id:int}")]
        public IActionResult Delete(int id)
        {
            return Ok();
        }
    }
}
