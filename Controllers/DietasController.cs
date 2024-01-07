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
        public IActionResult ExibirDietaPorHorario(string horario)
        {
            var horarioBanco = _context.Dietas.Find(horario);

            if(horarioBanco == null)
            {
                return NotFound();
            }

            return Ok(horarioBanco);
        }

        [HttpPost]
        public IActionResult AdicionarRefeicao(Dieta refeicao)
        {
            _context.Dietas.Add(refeicao);
            _context.SaveChanges();

            Console.WriteLine("Refeição adicionada com sucesso!");
            return NoContent();
        }

        [HttpPut("{id}")]
        public IActionResult AlterarRefeicao(int id, Dieta refeicao)
        {
            var refeicaoBanco = _context.Dietas.Find(id);

            if(refeicaoBanco == null)
            {
                return NotFound();
            }

            refeicaoBanco.Refeicao = refeicao.Refeicao;
            refeicaoBanco.Horario = refeicao.Horario;
            
            _context.Dietas.Update(refeicaoBanco);
            _context.SaveChanges();

            return NoContent();
        }
    }
}