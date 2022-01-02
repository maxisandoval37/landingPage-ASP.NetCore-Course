using landingPage.Models;
using SendGrid;
using SendGrid.Helpers.Mail;

namespace landingPage.Servicios
{
    public interface IServicioEmail
    {
        Task Enviar(ContactoDTO contacto);
    }

    public class ServicioEmailSendGrid: IServicioEmail
    {
        private readonly IConfiguration _configuration;

        public ServicioEmailSendGrid(IConfiguration configuration)
        {
            this._configuration = configuration;
        }

        public async Task Enviar(ContactoDTO contacto)
        {
            var apiKey = this._configuration.GetValue<string>("SENDGRID_API_KEY");
            var email = this._configuration.GetValue<string>("SENDGRID_FROM");
            var nombre = this._configuration.GetValue<string>("SENDGRID_NOMBRE");

            var cliente = new SendGridClient(apiKey);
            var from = new EmailAddress(email,nombre);
            var subject = "El cliente "+contacto.Email+" quiere contactarte";//asunto
            var to = new EmailAddress(email,nombre);
            
            var mensaje = contacto.Mensaje;
            var contenidoHTML = $@"<b>De:</b> {contacto.Nombre} <br> 
            <b>Email:</b> {contacto.Email} <br> 
            <b>Mensaje:</b> {contacto.Mensaje}  <br>";

            var emailUnico = MailHelper.CreateSingleEmail(from, to, subject, mensaje, contenidoHTML);
            await cliente.SendEmailAsync(emailUnico);
        }
    }
}