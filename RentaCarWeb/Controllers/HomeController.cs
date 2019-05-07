using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Commons.Concretes;
using Business.Concretes;
using RentaCarWeb.AracWebServis;
using Arac = Models.Concretes.Araclar;

namespace RentaCarWeb.Controllers
{
    public class HomeController : Controller
    {
        AracWebServisSoapClient aracServis = new AracWebServisSoapClient();
        AracController a = new AracController();
        public ActionResult Index()
        {
            ViewBag.Araclar = a.aracGetir();
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