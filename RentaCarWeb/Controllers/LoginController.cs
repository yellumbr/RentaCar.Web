using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Commons.Concretes;
using Business.Concretes;

namespace RentaCarWeb.Controllers
{
    public class LoginController : Controller
    {
        
        // GET: Login
        public ActionResult Index()
        {
            // /Admin/Reporting/ReportManagement
            // return RedirectToAction("Reporting", "ReportManagement", new { area = "Admin" })


            //It's very simply;)

            return View();

        }

        public ActionResult GirisYap()
        {
            return RedirectToAction("Index", "Kullanici");
        }
     

        
    }
}