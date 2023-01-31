using MimeKit;
using System.Net.Mail;

namespace eportfolio.Tools.Email
{
    public class Email : IEmail
    {
        private readonly SmtpClient _client;

        public Email(SmtpClient client)
        {
            _client = client;
        }

        public bool Envoyer(string expediteur, string objet, string message, string destinataire)
        {
            return Envoyer(new MailAddress(expediteur), objet, message, new MailAddress(destinataire));
        }

        public bool Envoyer(MailAddress expediteur, string objet, string message, MailAddress destinataire)
        {
            MailMessage metaMessage = new MailMessage(expediteur, destinataire);
            metaMessage.Subject = objet;
            metaMessage.Body = message;
            return Envoyer(metaMessage);
        }

        public bool Envoyer(MailMessage metaMessage)
        {
            _client.Send(metaMessage);
            return true;
        }

        //public bool Envoyer(string expediteur, string objet, string message, string destinataire)
        //{
        //    MimeMessage metaMessage = new MimeMessage();
        //    //de
        //    metaMessage.From.Add(new MailboxAddress(expediteur, expediteur));
        //    //vers
        //    metaMessage.To.Add(new MailboxAddress(destinataire, destinataire));
        //    //sujet
        //    metaMessage.Subject = objet;
        //    //message
        //    BodyBuilder builder = new BodyBuilder();
        //    builder.HtmlBody = message;
        //    metaMessage.Body = builder.ToMessageBody();

        //    MailMessage metamessage2= new MailMessage();


        //    //envoi
        //    IConfiguration section = _config.GetSection("Smtp");
        //    try {
        //        _client.Host = section.GetValue<string>("HOST");
        //        _client.Port = section.GetValue<int>("PORT");
        //        //_client.Authenticate(section.GetValue<string>("Email"), section.GetValue<string>("Password"));
        //        _client.Send(metaMessage);
        //        return true;
        //    } catch (Exception ex) { return false; }
        //}
    }
}
