using HealthBreath.Context.BancoContext;
using HealthBreath.Models;
using Microsoft.AspNetCore.Mvc;

namespace HealthBreath.Controllers.DietasController
{
    [ApiController]
    [Route("Dieta")]
    public class DietasController : ControllerBase
    {
        private readonly BancoContext _context;
        
        public DietasController(BancoContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult ExibirDietas()
        {
            var dietas = _context.Dietas.ToList();

            if(dietas == null)
            {
                return NotFound();
            }

            return Ok(dietas);
        }

        [HttpGet]
        public IActionResult ExibirDietaPorRefeicao(string refeicao)
        {
            var refeicaoBanco = _context.Dietas.Find(refeicao);

            if(refeicaoBanco == null)
            {
                return NotFound();
            }

            return Ok(refeicaoBanco);
        }

        [HttpPost]
        public IActionResult AdicionarRefeicao(Dieta dieta)
        {
            _context.Dietas.Add(dieta);
            _context.SaveChanges();

            Console.WriteLine("Refeição adicionada com sucesso!");
            return NoContent();
        }
    }
}