using System.Net.Mail;

namespace eportfolio.Tools.Email
{
    public interface IEmail
    {
        bool Envoyer(string expediteur, string objet, string message, string destinataire);
        bool Envoyer(MailAddress expediteur, string objet, string message, MailAddress destinataire);
        bool Envoyer(MailMessage metaMessage);
    }
}
