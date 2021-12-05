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
            var proyectos = ObtenerProyectos().Take(3).ToList();
            var modelo = new HomeIndexDTO() { ProyectosList = proyectos };
            return View(modelo);
        }

        private List<ProyectoDTO> ObtenerProyectos()
        {
            return new List<ProyectoDTO>()
            {
                new ProyectoDTO()
                {
                    Titulo = "Temporada 6",
                    Descripcion = "Rick y los demás se enteraron de la existencia de Negan cuando Daryl, " +
                    "Abraham y Sasha fueron emboscados por una porción de los Salvadores mientras volvían a " +
                    "Alexandría luego de alejar a la horda de caminantes que había escapado de la cantera. " +
                    "Eventualmente, el grupo llego a la colonia Hilltop en donde Jesus confirmó la existencia " +
                    "del tirano.",
                    Link = "https://thewalkingdead.fandom.com/es/wiki/Temporada_6",
                    ImagenURL = "/imgs/seasons/temp6.jpg"
                },
                new ProyectoDTO()
                {
                    Titulo = "Temporada 7",
                    Descripcion = "A través de su perverso juego, Negan terminó seleccionando a Abraham " +
                    "y lo asesinó brutalmente adelante de todos, aplastándole el cráneo con su bate de " +
                    "béisbol hasta dejarlo prácticamente irreconocible. No contento con esto, trató " +
                    "además de obligar a Rosita a mirar la sangre que chorreaba del arma homicida, " +
                    "provocando finalmente que Daryl ya no pudiera contenerse y rompiera la fila para " +
                    "tratar de golpearlo. ",
                    Link = "https://thewalkingdead.fandom.com/es/wiki/Temporada_7",
                    ImagenURL = "/imgs/seasons/temp7.jpg"
                },
                new ProyectoDTO()
                {
                    Titulo = "Temporada 8",
                    Descripcion = "Cuando Rick y sus tropas llegaron al Santuario con la intención de " +
                    "comenzar un enfrentamiento contra los bandidos, Negan junto a sus tenientes acudieron " +
                    "al llamado, donde el tirano líder se sorprendió por las tropas armadas contra él y " +
                    "escuchó atentamente como el oficial aseguró perdonar las vidas de los bandidos " +
                    "dentro - a excepción de la del infame villano - si aceptaban rendirse.",
                    Link = "https://thewalkingdead.fandom.com/es/wiki/Temporada_8",
                    ImagenURL = "/imgs/seasons/temp8.jpg"
                },
                new ProyectoDTO()
                {
                    Titulo = "Temporada 9",
                    Descripcion = "Durante el año y medio transcurrido desde el final de la gran guerra, " +
                    "Negan pasó el resto de sus vidas encerrado en la improvisada cárcel que contaba " +
                    "Alexandría y en ocasiones recibía la visita de Rick para ser informado del gran " +
                    "avance que llevaban en sus vidas sin la presenciar del reinado de terror que el " +
                    "infame villano había creado.",
                    Link = "https://thewalkingdead.fandom.com/es/wiki/Temporada_9",
                    ImagenURL = "/imgs/seasons/temp9.jpg"
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