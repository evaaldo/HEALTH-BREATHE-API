using HealthBreath.Context.BancoContext;
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
    }
}