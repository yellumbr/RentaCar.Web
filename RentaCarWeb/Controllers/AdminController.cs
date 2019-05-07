using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Commons.Concretes;
using Business.Concretes;
using RentaCarWeb.AracWebServis;
using Arac = Models.Concretes.Araclar;
using Musteriler = Models.Concretes.Musteriler;

namespace RentaCarWeb.Controllers
{
    public class AdminController : Controller
    {
       // GET: Admin
        public ActionResult Index()
        {
            return View();
        }


        //public ActionResult KullaniciEkle()
        //{
        //    return View();
        //}
        //public ActionResult KullaniciSil()
        //{
        //    return View();
        //}
        //public ActionResult KullaniciGuncelle()
        //{
        //    return View();
        //}
        //public ActionResult AracEkle()
        //{
        //    return View();
        //}
        //public ActionResult AracSil()
        //{
        //    return View();
        //}
        //public ActionResult AracGuncelle()
        //{
        //    return View();
        //}
        //public ActionResult Rapor()
        //{
        //    return View();
        //}
        //public ActionResult Rezerve()
        //{
        //    return View();
        //}
        //public ActionResult Kiralama()
        //{
        //    return View();
        //}
    }
   
}