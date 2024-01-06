using HealthBreath.Context.BancoContext;
using HealthBreath.Models;
using Microsoft.AspNetCore.Mvc;

namespace HealthBreath.Controllers.TreinosController
{
    [Route("Treinos")]
    [ApiController]
    public class TreinosController : ControllerBase
    {
        private readonly BancoContext _context;

        public TreinosController(BancoContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult ExibirTreinos()
        {
            var treinos = _context.Treinos.ToList();

            if(treinos == null)
            {
                return NotFound();
            }

            return Ok(treinos);
        }

        [HttpGet("{id}")]
        public IActionResult ExibirTreinoPorId(int id)
        {
            var treino = _context.Treinos.Find(id);

            if(treino == null)
            {
                return NotFound();
            }

            return Ok(treino);
        }

        [HttpPost]
        public IActionResult AdicionarTreino(Treino treino)
        {
            _context.Treinos.Add(treino);
            _context.SaveChanges();

            return Ok(treino);
        }

        [HttpPut("{id}")]
        public IActionResult AlterarTreino(int id, Treino treino)
        {
            var treinoBanco = _context.Treinos.Find(id);

            treinoBanco.Exercicios = treino.Exercicios;
            treinoBanco.DiaSemana = treino.DiaSemana;
            treinoBanco.Musculo = treino.Musculo;

            _context.Treinos.Update(treinoBanco);
            _context.SaveChanges();

            return NoContent();
        }
    }
}