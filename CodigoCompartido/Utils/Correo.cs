using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Compartido.Utils {
    public class Correo {
        
        public static void EnviarCorreo(string destino, string asunto, string cuerpo) {
            MailMessage email = new MailMessage();
            email.To.Add(new MailAddress(destino));
            email.From = new MailAddress("correo@footballxxi.com");
            email.Subject = asunto;
            email.Body = cuerpo;
            email.IsBodyHtml = true;
            email.Priority = MailPriority.Normal;

            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com";
            smtp.Port = 587;
            smtp.EnableSsl = true;
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new NetworkCredential("luisk301374@gmail.com", "lmuairsy001993");

            string output;
            try {
                smtp.Send(email);
                email.Dispose();
                output = "Correo electrónico se ha enviado satisfactoriamente.";
            } catch (Exception ex) {
                output = "Error al enviar correo electrónico: " + ex.Message;
            }

            Console.WriteLine(output);
        }

    }
}
