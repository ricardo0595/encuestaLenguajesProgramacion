using EncuestaLenguajesProgramacion.Models;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace EncuestaLenguajesProgramacion.Controllers
{
    public class FormularioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult GuardarRespuesta([FromBody] EntradaUsuario usuario)
        {
            TempData["entradaUsuario"] = JsonSerializer.Serialize<EntradaUsuario>(usuario);
            return new JsonResult(true);

        }

    }
}
