using landingPage.Models;

namespace landingPage.Servicios
{

    public interface IRepositorioTemporadas
    {
        public List<TemporadaDTO> ObtenerProyectos();
    }
    public class RepositorioTemporadas: IRepositorioTemporadas
    {
        public List<TemporadaDTO> ObtenerProyectos()
        {
            return new List<TemporadaDTO>()
            {
                new TemporadaDTO()
                {
                    Titulo = "Temporada 6",
                    Descripcion = "Rick y los demás se enteraron de la existencia de Negan cuando Daryl, " +
                    "Abraham y Sasha fueron emboscados por una porción de los Salvadores mientras volvían a " +
                    "Alexandría.",
                    Link = "https://thewalkingdead.fandom.com/es/wiki/Temporada_6",
                    ImagenURL = "/imgs/seasons/temp6.jpg"
                },
                new TemporadaDTO()
                {
                    Titulo = "Temporada 7",
                    Descripcion = "Negan terminó seleccionando a Abraham " +
                    "y lo asesinó brutalmente adelante de todos, aplastándole el cráneo con su bate de " +
                    "béisbol. ",
                    Link = "https://thewalkingdead.fandom.com/es/wiki/Temporada_7",
                    ImagenURL = "/imgs/seasons/temp7.jpg"
                },
                new TemporadaDTO()
                {
                    Titulo = "Temporada 8",
                    Descripcion = "Cuando Rick y sus tropas llegaron al Santuario con la intención de " +
                    "comenzar un enfrentamiento contra los bandidos, Negan junto a sus tenientes acudieron " +
                    "al llamado, donde el tirano líder se sorprendió por las tropas armadas contra él.",
                    Link = "https://thewalkingdead.fandom.com/es/wiki/Temporada_8",
                    ImagenURL = "/imgs/seasons/temp8.jpg"
                },
                new TemporadaDTO()
                {
                    Titulo = "Temporada 9",
                    Descripcion = "Negan pasó el resto de sus días encerrado en la improvisada cárcel de " +
                    "Alexandría y en ocasiones recibía la visita de Rick para ser informado del " +
                    "avance que llevaban en sus vidas.",
                    Link = "https://thewalkingdead.fandom.com/es/wiki/Temporada_9",
                    ImagenURL = "/imgs/seasons/temp9.jpg"
                },
            };
        }
    }
}
