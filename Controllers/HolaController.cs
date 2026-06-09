using Microsoft.AspNetCore.Mvc;

namespace Practica1_ISW.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HolaController : Controller
    {
        [HttpGet("Saludar")]
        public IActionResult Saludar(string nombre)
        {
            return Ok($"Hola, {nombre}!");
        }
    }
}
