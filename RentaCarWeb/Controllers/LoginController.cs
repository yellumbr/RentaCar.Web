using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Commons.Concretes;
using Business.Concretes;
using RentaCarWeb.MusterilerWebServis;
using Musteriler = Models.Concretes.Musteriler;

namespace RentaCarWeb.Controllers
{
    public class LoginController : Controller
    {
        MusterilerWebServisSoapClient musteriServis = new MusterilerWebServisSoapClient();
        KullaniciController k = new KullaniciController();
        HomeController h = new HomeController();
        // GET: Login
        public ActionResult Index()
        {

            try
            {
                var kullanici = Request.Form["kullanici"];
                var sifre = Request.Form["sifre"];

                if (GirisYap(kullanici, sifre))
                    return RedirectToAction("Index","Home");
                Console.WriteLine("Girdim");
                return View();
            }
            catch (Exception ex)
            {
                return View();
            }
        }
       
        public ActionResult KayitOl()
        {
            return View();
        }
        private List<Musteriler> musteriGetir()
        {

            try
            {
                using (var musteriServis = new MusterilerWebServis.MusterilerWebServisSoapClient())
                {
                    List<Musteriler> musteriler = new List<Musteriler>();
                    foreach (var cevaplayanMusteri in musteriServis.MusteriHepsiniSec().OrderBy(x => x.MusteriId)
                        .ToList())
                    {
                        Musteriler musteri = new Musteriler()
                        {
                            MusteriId = cevaplayanMusteri.MusteriId,
                            Sifre = cevaplayanMusteri.Sifre,
                            KullaniciAdi = cevaplayanMusteri.KullaniciAdi,
                            EhliyetYil = cevaplayanMusteri.EhliyetYil,
                            EhliyetTipi = cevaplayanMusteri.EhliyetTipi,
                            TcKimlik = cevaplayanMusteri.TcKimlik,
                            Ad = cevaplayanMusteri.Ad,
                            Soyad = cevaplayanMusteri.Soyad,
                            Adres = cevaplayanMusteri.Adres,
                            Telefon = cevaplayanMusteri.Telefon,
                            Email = cevaplayanMusteri.Email,
                            DogumTarihi = cevaplayanMusteri.DogumTarihi,

                        };

                        musteriler.Add(musteri);
                    }
                    return musteriler;

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private bool GirisYap(string kullaniciadi, string sifre)
        {
            bool success=false;
            try
            {
                using (var musteri = new MusterilerWebServis.MusterilerWebServisSoapClient())
                {
                    foreach (var item in musteriGetir())
                    {
                        if (item.KullaniciAdi == kullaniciadi && item.Sifre == sifre)
                        {
                            success = true;
                        }
                        
                    }
                }


                //MÜŞTERİNİN EKLENİP EKLENMEDİĞİ KONTROL EDİLİR
                return success ;
            }

            catch (Exception ex)//BAŞARISIZ OLURSA MESAJ DÖNER
            {
                throw ex;
            }

        }
    }
}