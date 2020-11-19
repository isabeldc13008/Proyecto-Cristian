using MailKit.Net.Smtp;
using Microsoft.Extensions.Options;
using MimeKit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppFinal.Models.Email
{
    public interface IEmailSenderU
    {
        Task SendEmailAsync(string mensaje, string encabezado, string email);
    }
    public class EmailSender:IEmailSenderU
    {
        private readonly ConfiguracionEmail _configuracionEmail;
        public EmailSender(IOptions<ConfiguracionEmail> configuracion){
            _configuracionEmail = configuracion.Value;
        }
        public async Task SendEmailAsync(string email, string encabezado, string mensaje)
        {
            try { 

                var MimeMensaje = new MimeMessage();
                MimeMensaje.From.Add(new MailboxAddress(_configuracionEmail.SenderName, _configuracionEmail.SenderEmail));
                MimeMensaje.To.Add(new MailboxAddress(email));
                MimeMensaje.Subject = encabezado;
                MimeMensaje.Body = new TextPart("Html") {
                    Text = mensaje
                };
                using (var cliente = new SmtpClient()) 
                {
                    cliente.ServerCertificateValidationCallback = (a, b, e, c) => true;
                    await cliente.ConnectAsync(_configuracionEmail.Server, _configuracionEmail.Port,true);
                    await cliente.AuthenticateAsync(_configuracionEmail.UserName, _configuracionEmail.Password);
                    await cliente.SendAsync(MimeMensaje);
                    await cliente.DisconnectAsync(true);
                }
            }
            catch (Exception a) {
             throw new InvalidOperationException(a.Message);
            }
        }
    }
}
