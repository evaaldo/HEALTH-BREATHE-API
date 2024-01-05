using HealthBreath.Context.BancoContext;
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
    }
}