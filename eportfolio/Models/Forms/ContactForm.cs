using System.ComponentModel.DataAnnotations;

namespace eportfolio.Models.Forms
{
    public class ContactForm
    {
        [Required]
        public string Expediteur { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Message { get; set; }

        public ContactForm() { }
        public ContactForm(string expediteur, string email, string message)
        { 
            Expediteur = expediteur; 
            Email = email;
            Message = message;
        }
    }
}
