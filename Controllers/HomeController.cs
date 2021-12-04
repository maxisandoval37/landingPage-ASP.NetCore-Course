using landingPage.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace landingPage.Controllers
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
            var personaje = new Personaje()
            {
                Nombre = "Negan",
                Kills = 138
            };
            return View("Index", personaje);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Season()
        {
            return View();
        }

        private List<ProyectoDTO> ObtenerProyectos()
        {
            return new List<ProyectoDTO>()
            {
                new ProyectoDTO()
                {
                    Titulo = "",
                    Descripcion = "",
                    Link = "",
                    ImagenURL = ""
                },
                new ProyectoDTO()
                {
                    Titulo = "",
                    Descripcion = "",
                    Link = "",
                    ImagenURL = ""
                },
                new ProyectoDTO()
                {
                    Titulo = "",
                    Descripcion = "",
                    Link = "",
                    ImagenURL = ""
                },
                new ProyectoDTO()
                {
                    Titulo = "",
                    Descripcion = "",
                    Link = "",
                    ImagenURL = ""
                },
            };
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}