using Microsoft.AspNetCore.Mvc;
using TreinamentoWebAPI.Data;
using TreinamentoWebAPI.Domain;

namespace TreinamentoWebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PoderController : ControllerBase
    {
        private readonly AppDbContext _context;

        public PoderController(AppDbContext context)
        {
            _context = context; 
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_context.Poderes.ToList());
        }

        [HttpGet("{id:int}")]
        public IActionResult GetById(int id)
        {
            var poder = _context.Poderes.SingleOrDefault(x => x.Id == id);

            if (poder == null) 
            {
                return NotFound("Não Encontrado!");
            }

            return Ok(poder);
        }

        [HttpPost]
        public IActionResult Post([FromBody] string habilidade)
        {
            try
            {
                if (!String.IsNullOrEmpty(habilidade))
                {
                    var poder = new Poder();

                    poder.Habilidade = habilidade;

                    _context.Poderes.Add(poder);
                    _context.SaveChanges();

                    return Ok();
                }

                return BadRequest();
            }
            catch (Exception)
            {

                return BadRequest("Ocorreu um problema com sua solicitação!");
            }
        }

        [HttpPut("{id:int}")]
        public IActionResult Put(int id, string habilidade)
        {
            var poder = _context.Poderes.FirstOrDefault(x => x.Id == id);

            if (poder == null)
            {
                return NotFound();
            }

            poder.Habilidade = habilidade;
            _context.Poderes.Update(poder);
            _context.SaveChanges(); 

            return Ok();
        }

        [HttpDelete("{id:int}")]
        public IActionResult Delete(int id)
        {
            var poder = _context.Poderes.FirstOrDefault(x => x.Id == id);

            if (poder == null)
            {
                return NotFound();
            }

            _context.Poderes.Remove(poder); 
            _context.SaveChanges();

            return NoContent();
        }
    }
}
