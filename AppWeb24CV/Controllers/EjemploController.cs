using AppWeb24CV.Models;
using Microsoft.AspNetCore.Mvc;

namespace AppWeb24CV.Controllers
{
    public class EjemploController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Contacto()
        {
            Persona persona = new Persona();
            persona.Nombre = "Moises";
            persona.Apellidos = "Torres";
            persona.FechaNacimiento = new DateTime(1982, 01, 15);
            return View(persona);
        }
    }
}
