using Microsoft.AspNetCore.Mvc;

namespace Practica1_ISW.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class NotasController : Controller
    {
        [HttpPost("Notas")]
        public IActionResult Notas([FromBody] NotasRequest request)
        {
            var notas = request.Notas;
            double promedio = notas.Average();
            double maximo = notas.Max();
            double minimo = notas.Min();
            int aprobados = notas.Count(n => n >= 70);
            int reprobados = notas.Count(n => n < 70);
            return Ok(new { notas, promedio, maximo, minimo, aprobados, reprobados });
        }
    }

    public class NotasRequest
    {
        public List<double> Notas { get; set; }
    }
}
