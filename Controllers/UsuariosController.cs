using HealthBreath.Context.BancoContext;
using HealthBreath.Models;
using Microsoft.AspNetCore.Mvc;

namespace HealthBreath.Controllers.UsuariosController
{
    [ApiController]
    [Route("Usuarios")]
    public class UsuariosController : ControllerBase
    {
        private readonly BancoContext _context;

        public UsuariosController(BancoContext context)
        {
            _context = context;
        }

        public IActionResult Autenticar(string nome, string senha)
        {
            var usuario = _context.Usuarios.Find(nome);

            if(usuario == null)
            {
                return NotFound();
            }

            if(senha == usuario.Senha && usuario.Administrador == true)
            {
                return Ok();
            }

            return NotFound();
        }
    }
}