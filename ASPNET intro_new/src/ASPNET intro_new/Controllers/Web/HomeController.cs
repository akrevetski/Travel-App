using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using ASPNET_intro_new.Models;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace ASPNET_intro_new.Controllers
{
    public class HomeController : Controller
    {
        private TripsRepository repository;
        public HomeController(TripsRepository rep)
        {
            rep = repository;
        }
        // GET: /<controller>
        public ActionResult Index()
        {
            Trip MyTrip = new Trip();
            MyTrip.ID = 12345;
            MyTrip.Name = "Trip to Florida";
            MyTrip.DateCreated = DateTime.Now;
            MyTrip.Stops = null;
            MyTrip.UserName = "Joe_Schmoe";
            ViewBag.Message = "myTrip";
            return View(repository);
        }
        public ActionResult About()
        {
            ViewBag.Message = "About us";
            return View();
        }
        public ActionResult Contact()
        {
            ViewBag.Message = "Contact us";
            return View();
        }
    }
}

