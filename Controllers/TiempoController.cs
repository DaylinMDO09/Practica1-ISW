using Microsoft.AspNetCore.Mvc;

namespace Practica1_ISW.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TiempoController : Controller
    {
        [HttpGet("ObtenerTiempo")]
        public IActionResult ObtenerTiempo(int segundos)
        {
            int horas = segundos / 3600;
            int minutos = (segundos % 3600) / 60;
            int segundosRestantes = segundos % 60;
            return Ok($"{horas} horas, {minutos} minutos y {segundosRestantes} segundos");
        }
    }
}
