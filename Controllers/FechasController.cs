using Microsoft.AspNetCore.Mvc;

namespace Practica1_ISW.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FechasController : Controller
    {
        [HttpGet("DiferenciaEntreFechas")]
        public IActionResult DiferenciaEntreFechas(DateTime desde, DateTime hasta)
        {
            TimeSpan diferencia = hasta - desde;
            return Ok($"La diferencia entre las fechas es de {diferencia.Days} días.");
        }
        [HttpGet("AgregarFecha")]
        public IActionResult AgregarFecha(DateTime fecha, int dias)
        {
            DateTime nuevaFecha = fecha.AddDays(dias);
            return Ok($"La nueva fecha después de agregar {dias} días es: {nuevaFecha:dd/MM/yyyy}");
        }
    }
}
