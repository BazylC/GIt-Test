using DutchTreat.Services;
using KrzyweAccom.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace KrzyweAccom.Controllers
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

        [HttpGet("contact")]
        public IActionResult Contact()
        {
         
            return View();
        }

        [HttpPost("contact")]
        public IActionResult Contact(ContactViewModel model)
        {
            if (ModelState.IsValid)
            {
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress("bazyl1616@gmail.com");
                mail.To.Add("bazyl1616@gmail.com");

                mail.Subject = model.Subject;
                mail.IsBodyHtml = true;

                string content = "Name: " + model.Name;
                content += "<br/> Email: " + model.Email;
                content += "<br/> Message: " + model.Message;

                mail.Body = content;

                SmtpClient smtp = new SmtpClient("smtp.gmail.com ");

                NetworkCredential networkCredential = new NetworkCredential("bazyl1616@gmail.com", "wtdevqpymfnrwprv");
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = networkCredential;
                smtp.Port = 587;
                smtp.EnableSsl = true;
                smtp.Send(mail);


                ViewBag.UserMessage = "Mail Sent";
                ModelState.Clear();
            }


            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
