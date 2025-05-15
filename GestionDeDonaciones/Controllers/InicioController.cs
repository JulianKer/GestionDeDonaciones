using Microsoft.AspNetCore.Mvc;

namespace GestionDeDonaciones.Controllers
{
    public class InicioController : Controller
    {
        public IActionResult Saludo()
        {
            return View();
        }
    }
}
