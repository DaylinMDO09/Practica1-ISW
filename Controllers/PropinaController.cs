using Microsoft.AspNetCore.Mvc;

namespace Practica1_ISW.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PropinaController : Controller
    {
        [HttpGet("CalcularPropina")]
        public IActionResult CalcularPropina(double monto, double porcentaje)
        {
            double propina = monto * porcentaje / 100;
            double total = monto + propina;
            return Ok(new {monto, porcentaje, propina, total});
        }
    }
}
