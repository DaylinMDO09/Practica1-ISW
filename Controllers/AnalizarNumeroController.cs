using Microsoft.AspNetCore.Mvc;

namespace Practica1_ISW.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AnalizarNumeroController : Controller
    {
        [HttpGet("AnalizarNumeros")]
        public IActionResult AnalizarNumero(int numero)
        {
            bool esPar = numero % 2 == 0;
            bool esPrimo = EsPrimo(numero);
            string signo = numero > 0 ? "positivo" : numero < 0 ? "negativo" : "cero";
            return Ok($"El número {numero} es {signo}, {(esPar ? "par" : "impar")} y {(esPrimo ? "primo" : "no primo")}.");
        }

        private bool EsPrimo(int numero)
        {
            if (numero <= 1) return false;
            for (int i = 2; i <= Math.Sqrt(numero); i++)
            {
                if (numero % i == 0) return false;
            }
            return true;
        }
    }
}
