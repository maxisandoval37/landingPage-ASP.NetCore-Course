using landingPage.Models;
using landingPage.Servicios;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace landingPage.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IRepositorioTemporadas _repositorioProyectos;
        private readonly IServicioEmail _servicioEmail;

        public HomeController(ILogger<HomeController> logger, 
            IRepositorioTemporadas repositorioProyectos, 
            IServicioEmail servicioEmail)
        {
            _logger = logger;
            _repositorioProyectos = repositorioProyectos;
            _servicioEmail = servicioEmail;
        }

        public IActionResult Index()
        {
            var personaje = new Personaje()
            {
                Nombre = "Negan",
                Kills = 138
            };
            _logger.LogInformation("Vista Index cargada correctamente");
            return View("Index", personaje);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Season()
        {
            var proyectos = _repositorioProyectos.ObtenerProyectos().ToList();
            var modelo = new HomeIndexDTO() { TemporadasList = proyectos };
            return View(modelo);
        }

        public IActionResult Contact()
        {
            return View();
        }

        [HttpPost]//Esta acción se va a realizar cuando recibamos atributos de la vista
        public async Task<IActionResult> Contact(ContactoDTO contactoDTO)
        {
            _logger.LogInformation(contactoDTO.ToString());
            await _servicioEmail.Enviar(contactoDTO);
            return RedirectToAction("Thanks");
        }

        public IActionResult Thanks()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}