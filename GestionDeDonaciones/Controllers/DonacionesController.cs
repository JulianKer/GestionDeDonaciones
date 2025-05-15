using GestionDeDonaciones.Entidades;
using GestionDeDonaciones.Models;
using GestionDeDonaciones.Servicios;
using Microsoft.AspNetCore.Mvc;

namespace GestionDeDonaciones.Controllers
{
    public class DonacionesController : Controller
    {

        public IDonacionServicio _donacionServicio;

        public DonacionesController(IDonacionServicio donacionServicio)
        {
            this._donacionServicio = donacionServicio;
        }



        [HttpGet]
        public IActionResult Registrar()
        {
            return View("RegistrarDonacion", new DonacionViewModel());
        }

        
        [HttpPost]
        public IActionResult Registrar(DonacionViewModel nuevaDonacion)
        {
            if (!ModelState.IsValid)
            {
                return View("RegistrarDonacion", nuevaDonacion);
            }

            this._donacionServicio.registrarDonacion(nuevaDonacion.convertiteAEntidad());
            TempData["msjExito"] = "La persona: " + nuevaDonacion._nombreDelDonante + "ha donado: $" + nuevaDonacion._montoDeDonacion;
            return RedirectToAction("Listado");
        }
        
        public IActionResult Listado()
        {
            return View("ListadoDeDonaciones", this._donacionServicio.obtenerDonaciones());
        }
    }
}
