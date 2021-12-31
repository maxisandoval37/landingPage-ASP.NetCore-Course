namespace landingPage.Models
{
    public class ContactoDTO
    {
        public string? Nombre { get; set; }
        public string? Email { get; set; }
        public string? Mensaje { get; set; }

        public override string ToString()
        {
            return "Contacto: " + Nombre + "-" + Email + "-"+ Mensaje;
        }
    }
}
