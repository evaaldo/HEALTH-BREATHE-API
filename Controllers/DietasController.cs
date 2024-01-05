using HealthBreath.Context.BancoContext;
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
    }
}