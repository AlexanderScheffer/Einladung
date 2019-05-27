using Einladung.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PartyInvites.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            // Die aktuelle Zeitabfrage
            int hour = DateTime.Now.Hour;

            if (hour < 12)
                {
                   ViewBag.Greeting = "Schönen guten Morgen!";
                }
                else if (hour < 18)
                 {
                  ViewBag.Greeting = "Schönen guten Tag!";
                 }
               else
                 {
                  ViewBag.Greeting = "Schönen guten Abend!";
                 }
          return View();
        }
        [HttpGet]
        public ViewResult RsvpForm()
        {
            return View();
        }

        [HttpPost]
        public ViewResult RsvpForm(GuestResponce guest)
        {
            // Hier werden die Gastinfos zum 
            // Veranstalter gesendet
            return View("Thanks", guest);
        }
    }

}