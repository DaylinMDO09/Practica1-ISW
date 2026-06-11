using Microsoft.AspNetCore.Mvc;

namespace Practica1_ISW.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EdadController : Controller
    {
        [HttpGet("CalcularEdad")]
        public IActionResult CalcularEdad(DateTime fechaNacimiento)
        {
            DateTime fechaActual = DateTime.Today;
            int edad = fechaActual.Year - fechaNacimiento.Year;
            if (fechaNacimiento.Date > fechaActual.AddYears(-edad)) edad--;

            string signoZodiacal = ObtenerSignoZodiacal(fechaNacimiento);
            return Ok(new { fechaNacimiento, edad, signoZodiacal });
        }

        private string ObtenerSignoZodiacal(DateTime fechaNacimiento)
        {
            int dia = fechaNacimiento.Day;
            int mes = fechaNacimiento.Month;

            switch (mes)
            {
                case 1: return (dia <= 20) ? "Capricornio" : "Acuario";
                case 2: return (dia <= 19) ? "Acuario" : "Piscis";
                case 3: return (dia <= 20) ? "Piscis" : "Aries";
                case 4: return (dia <= 20) ? "Aries" : "Tauro";
                case 5: return (dia <= 21) ? "Tauro" : "Géminis";
                case 6: return (dia <= 21) ? "Géminis" : "Cáncer";
                case 7: return (dia <= 22) ? "Cáncer" : "Leo";
                case 8: return (dia <= 23) ? "Leo" : "Virgo";
                case 9: return (dia <= 23) ? "Virgo" : "Libra";
                case 10: return (dia <= 23) ? "Libra" : "Escorpio";
                case 11: return (dia <= 22) ? "Escorpio" : "Sagitario";
                case 12: return (dia <= 21) ? "Sagitario" : "Capricornio";
                default: return "Desconocido";
            }
        }
    }
}