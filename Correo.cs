using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ordinario
{
    internal class Correo
    {
        public void EnviarCorreo(string error)
        {
            try
            {
                MailMessage mensaje = new MailMessage();
                mensaje.From = new MailAddress("113149@alumnouninter.mx"); // Reemplaza con tu cuenta de envío
                mensaje.To.Add("ecorrales@uninter.edu.mx");
                mensaje.Subject = "Profeeeee";
                mensaje.Body = $"Se ha producido el siguiente error:\n\n{error}";
                mensaje.IsBodyHtml = false;

                SmtpClient smtp = new SmtpClient("smtp.office365.com", 587);
                smtp.Credentials = new NetworkCredential("113149@alumnouninter.mx", "4Ngela666!"); // Usa contraseñas seguras
                smtp.EnableSsl = true;

                smtp.Send(mensaje);
            }
            catch (Exception ex)
            {
                // Puedes loguear o relanzar el error
                throw new Exception("Error al enviar el correo: " + ex.Message, ex);
            }
        }
    }
}
