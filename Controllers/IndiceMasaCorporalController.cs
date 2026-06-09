using Microsoft.AspNetCore.Mvc;

namespace Practica1_ISW.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class IndiceMasaCorporalController : Controller
    {
        [HttpGet("Calcular Indice de Masa Corporal")]
        public IActionResult CalcularIndiceMasaCorporal(double peso, double altura)
        {
            if (altura <= 0)
            {
                return BadRequest("La altura debe ser mayor que cero.");
            }

            double imc = peso / (altura * altura);
            string categoria;

            if (imc < 18.5)
            {
                categoria = "Bajo peso";
            }
            else if (imc < 24.9)
            {
                categoria = "Normal";
            }
            else if (imc < 29.9)
            {
                categoria = "Sobrepeso";
            }
            else
            {
                categoria = "Obesidad";
            }

            return Ok($"El IMC es {imc:F2} y la categoría es {categoria}.");
        }
    }
}
