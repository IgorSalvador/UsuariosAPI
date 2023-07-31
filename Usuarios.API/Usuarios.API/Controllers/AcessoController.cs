using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Usuarios.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AcessoController : ControllerBase
    {
        [HttpGet]
        [Authorize(Policy = "IdadeMinima")]
        public IActionResult Get()
        {
            return Ok("Acesso permitido!");
        }
    }
}
