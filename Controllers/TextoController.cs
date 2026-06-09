using Microsoft.AspNetCore.Mvc;

namespace Practica1_ISW.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TextoController : Controller
    {
        [HttpGet("Texto")]
        public IActionResult ContarTexto(string texto)
        {
            int longitud = texto.Length;
            int palabras = texto.Split(' ', StringSplitOptions.RemoveEmptyEntries).Length;
            int vocales = texto.Count(c => "aeiouAEIOU".Contains(c));
            return Ok($"El texto tiene {longitud} caracteres, {palabras} palabras y {vocales} vocales.");
        }

        [HttpGet("InvertirTexto")]
        public IActionResult InvertirTexto(string texto)
        {
            char[] caracteres = texto.ToCharArray();
            Array.Reverse(caracteres);
            string textoInvertido = new string(caracteres);
            return Ok($"El texto invertido es: {textoInvertido}");
        }
    }
}
