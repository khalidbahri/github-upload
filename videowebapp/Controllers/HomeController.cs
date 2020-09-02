using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using videowebapp.Models;
using Microsoft.ApplicationInsights;


namespace videowebapp.Controllers
{
    public class HomeController : Controller
    {

        private TelemetryClient aiClient;

        public HomeController(TelemetryClient aiClient)
        {
            this.aiClient = aiClient;
        }

        [HttpPost]
        public ActionResult Like(string button)
        {
            this.aiClient.TrackEvent("LikeClicked");
            this.aiClient.TrackEvent("SabirJoined");
            ViewBag.Message = "Thank you for your response";
          
            return View("Index");
        }


        public IActionResult Index()
        {
            return View();
        }

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
