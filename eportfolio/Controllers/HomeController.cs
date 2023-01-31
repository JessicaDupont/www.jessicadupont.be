using eportfolio.Models;
using eportfolio.Models.Forms;
using eportfolio.Tools.Email;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace eportfolio.Controllers
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
            return View();
        }
        public IActionResult GitHub()
        {
            return Redirect("https://github.com/JessicaDupont");
        }
        public IActionResult LinkedIn()
        {
            return Redirect("https://www.linkedin.com/in/jessica-dupont-1990/");
        }
        //public IActionResult Contact()
        //{
        //    ContactForm form = new ContactForm();
        //    return View(form);
        //}
        //[HttpPost]
        //public IActionResult Contact(ContactForm form)
        //{
        //    if(ModelState.IsValid)
        //    {
        //        //TODO envoi du mail
        //        IEmail mailing = new Email();
        //        mailing.Envoyer(form.Email, form.Expediteur, form.Message, "jessica.dupont1990@gmail.com");
        //        //TODO message à l'utilisateur
        //    }
        //    return View(form);
        //}

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}