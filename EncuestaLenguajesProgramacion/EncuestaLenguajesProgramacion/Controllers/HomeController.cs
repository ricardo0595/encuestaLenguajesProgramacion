using EncuestaLenguajesProgramacion.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace EncuestaLenguajesProgramacion.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
          
            EntradaUsuario entrada = null;
            if (TempData["entradaUsuario"] != null)
            {
                entrada = JsonSerializer.Deserialize<EntradaUsuario>((String)TempData["entradaUsuario"]);
                ManejadorListaLenguajes.AgregarEntrada(entrada.LenguajePrimario, entrada.LenguajeSecundario);
            }
            ViewData["listaLenguajes"] = ManejadorListaLenguajes.ListaLenguajes;
            return View("Index");
        }

     

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }



    }
}