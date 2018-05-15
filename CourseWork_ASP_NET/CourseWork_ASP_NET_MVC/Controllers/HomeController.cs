using CourseWork_ASP_NET_MVC.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CourseWork_ASP_NET_MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly CinemaContext _ctx = new CinemaContext();

        public ActionResult Index()
        {
            //IEnumerable<ShowStatus> st = _ctx.ShowStatuses;
            //ViewBag.Statuses = st;
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}