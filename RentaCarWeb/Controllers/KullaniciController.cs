using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Commons.Concretes;
using Business.Concretes;
using Kullanici = Models.Concretes.Kullanici;


namespace RentaCarWeb.Controllers
{
    public class KullaniciController : Controller
    {
        // GET: Kullanici
        public ActionResult Index()
        {
            return View();
        }
        //GET: Customer/Details/5
        public ActionResult Detay(int id)
        {
            ViewBag.id = id;
            return View();
        }

        //GET: Customer/Create

       // POST: Customer/Create
       //[HttpPost]
       //[ValidateAntiForgeryToken]
        public ActionResult Create()
        {
            if (!ModelState.IsValid)
            {
                Console.WriteLine("Girmedim");
                return View();
            }
           
                var ad = Request.Form["ad"];
                var soyad = Request.Form["soyad"];
                var tc = Request.Form["tcnumarasi"];
                var adres = Request.Form["adres"];
                var tel = Request.Form["telno"];
                var mail = Request.Form["mailadres"];
                var dogum = DateTime.Parse(Request.Form["dogumtarihi"]);
                var kuladi = Request.Form["kullaniciadi"];
                var sifre = Request.Form["sifre"];
                var ehliyettarih = DateTime.Parse(Request.Form["ehliyettarihi"]);
                var ehliyettipi = Request.Form["Ehliyettipi"];
                //if (MusteriEkle(ad,soyad,tc,adres,tel,mail,dogum,kuladi,sifre,ehliyettarih,ehliyettipi))
                //    return RedirectToAction("Create");
                Console.WriteLine("Girdim");
                return View();
            
            
        }

        public ActionResult Duzenle()
        {
            return View();
        }

        //public ActionResult Duzenle(int id)
        //{
        //    ViewBag.id = id;
        //    return View();
        //}
        
        
        //GET: Customer/Edit/5
        //public ActionResult Edit(int id)
        //    {
        //    try
        //    {
        //        ViewBag.musteriler = musteriGetir();
        //        return View(musteriServis.MusteriIdSec(id));
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception("Customer doesn't exists.");
        //    }
        // }

    //    //POST: Customer/Edit/5
    //    [HttpPost]
    //    public ActionResult Edit(int id, FormCollection collection)
    //    {
    //        ViewBag.musteriler = musteriGetir();
    //        if (!ModelState.IsValid)
    //        {
    //            return View();
    //        }
    //        try
    //        {
    //            var ad = Request.Form["ad"];
    //            var soyad = Request.Form["soyad"];
    //            var tc = Request.Form["tcnumarasi"];
    //            var adres = Request.Form["adres"];
    //            var tel = Request.Form["telno"];
    //            var mail = Request.Form["mailadres"];
    //            var dogum = DateTime.Parse(Request.Form["dogumtarihi"]);
    //            var kuladi = Request.Form["kullaniciadi"];
    //            var sifre = Request.Form["sifre"];
    //            var ehliyettarih = DateTime.Parse(Request.Form["ehliyettarihi"]);
    //            var ehliyettipi = Request.Form["Ehliyettipi"];
    //            if (KullaniciGuncelle(id,ad, soyad, tc, adres, tel, mail, dogum, kuladi, sifre, ehliyettarih, ehliyettipi))
    //                return RedirectToAction("Index");
                

    //            return View();
    //        }
    //        catch
    //        {
    //            return View();
    //        }
    //    }

    //    //GET: Customer/Delete/5
    //    public ActionResult Delete(int id)
    //    {
    //        try
    //        {
    //            if (musteriServis.MusteriIdSil(id))
    //                return RedirectToAction("ListAll");
    //            return RedirectToAction("ListAll");
    //        }
    //        catch (Exception ex)
    //        {
    //            throw new Exception("Operation failed!", ex);
    //        }
    //    }

    //    public ActionResult ListAll()
    //    {
    //        try
    //        {
    //            IList<MusterilerWebServis.Musteriler> musteriler = musteriServis.MusteriHepsiniSec();
    //            return View(musteriler);
    //        }
    //        catch (Exception ex)
    //        {
    //            throw new Exception("Customer doesn't exists.");
    //        }
    //    }
    //    private bool MusteriEkle(string ad, string soyad, string tckimlik, string adres, string telefon, string email,
    //        DateTime dogumtarihi, string kullaniciadi, string sifre, DateTime ehliyetyil, string ehliyettipi)
    //    {

    //        bool success;
    //        try
    //        {
    //            using (var musteri = new MusterilerWebServis.MusterilerWebServisSoapClient())
    //            {
    //                success = musteri.MusteriEkle(new MusterilerWebServis.Musteriler()
    //                {
    //                    Ad = ad,
    //                    Soyad = soyad,
    //                    TcKimlik = tckimlik,
    //                    Adres = adres,
    //                    Telefon = telefon,
    //                    Email = email,
    //                    DogumTarihi = dogumtarihi,
    //                    KullaniciAdi = kullaniciadi,
    //                    Sifre = sifre,
    //                    EhliyetYil = ehliyetyil,
    //                    EhliyetTipi = ehliyettipi
    //                });
    //            }
    //            var message = success ? "done" : "failed";

    //            //MÜŞTERİNİN EKLENİP EKLENMEDİĞİ KONTROL EDİLİR
    //            return success;
    //        }

    //        catch (Exception ex)//BAŞARISIZ OLURSA MESAJ DÖNER
    //        {
    //            throw ex;
    //        }

    //    }

    //    private List<Musteriler> musteriGetir()
    //    {

    //        try
    //        {
    //            using (var musteriServis = new MusterilerWebServis.MusterilerWebServisSoapClient())
    //            {
    //                List<Musteriler> musteriler = new List<Musteriler>();
    //                foreach (var cevaplayanMusteri in musteriServis.MusteriHepsiniSec().OrderBy(x => x.MusteriId)
    //                    .ToList())
    //                {
    //                    Musteriler musteri = new Musteriler()
    //                    {
    //                        MusteriId = cevaplayanMusteri.MusteriId,
    //                        Sifre = cevaplayanMusteri.Sifre,
    //                        KullaniciAdi = cevaplayanMusteri.KullaniciAdi,
    //                        EhliyetYil = cevaplayanMusteri.EhliyetYil,
    //                        EhliyetTipi = cevaplayanMusteri.EhliyetTipi,
    //                        TcKimlik = cevaplayanMusteri.TcKimlik,
    //                        Ad = cevaplayanMusteri.Ad,
    //                        Soyad = cevaplayanMusteri.Soyad,
    //                        Adres = cevaplayanMusteri.Adres,
    //                        Telefon = cevaplayanMusteri.Telefon,
    //                        Email = cevaplayanMusteri.Email,
    //                        DogumTarihi = cevaplayanMusteri.DogumTarihi,

    //                    };

    //                    musteriler.Add(musteri);
    //                }
    //                return musteriler;

    //            }
    //        }
    //        catch (Exception ex)
    //        {
    //            throw ex;
    //        }
    //    }

    //    private bool KullaniciGuncelle(int id,string ad, string soyad, string tckimlik, string adres, string telefon, string email,
    //        DateTime dogumtarihi, string kullaniciadi, string sifre, DateTime ehliyetyil, string ehliyettipi)
    //    {

    //        bool success = false;
    //        try
    //        {

    //            List<Musteriler> musteriler = new List<Musteriler>();
    //            musteriler = musteriGetir();

    //            using (var musteriServis = new MusterilerWebServis.MusterilerWebServisSoapClient())
    //            {
    //                foreach (var item in musteriler)
    //                {
    //                    if (kullaniciadi == item.KullaniciAdi)
    //                    {
    //                        success = musteriServis.MusteriEkle(new MusterilerWebServis.Musteriler()
    //                        {
    //                            MusteriId = item.MusteriId,
    //                            Sifre = sifre,
    //                            KullaniciAdi = kullaniciadi,
    //                            EhliyetYil = ehliyetyil,
    //                            EhliyetTipi = ehliyettipi,
    //                            TcKimlik = tckimlik,
    //                            Ad = ad,
    //                            Soyad = soyad,
    //                            Adres = adres,
    //                            Telefon = telefon,
    //                            Email = email,
    //                            DogumTarihi = dogumtarihi

    //                        });
    //                        var message = success ? "done" : "failed";
    //                    }

    //                }

    //                //MÜŞTERİNİN EKLENİP EKLENMEDİĞİ KONTROL EDİLİR
    //                return success;
    //            }
    //        }
    //        catch (Exception ex)
    //        {

    //            throw ex;
    //        }

    //    }

    //    private bool KullaniciSil(string kullaniciadi)
    //    {
    //        bool success = false;
    //        try
    //        {
    //            List<Musteriler> musteriler = new List<Musteriler>();
    //            musteriler = musteriGetir();
    //            using (var musteriServis = new MusterilerWebServis.MusterilerWebServisSoapClient())
    //            {
    //                foreach (var item in musteriler)
    //                {
    //                    if (item.KullaniciAdi == kullaniciadi)
    //                    {
    //                        success = musteriServis.MusteriIdSil(item.MusteriId);
    //                        musteriler.Remove(item);

    //                    }
    //                }
    //                return success;
    //            }

    //        }
    //        catch (Exception ex)
    //        {
    //            throw ex;
    //        }
    //    }

    //    private Musteriler IdSec(int ID)
    //    {
    //        try
    //        {
    //            using (var musteriServis = new MusterilerWebServisSoapClient())
    //            {
    //                Musteriler castedCustomer = null;
    //                MusterilerWebServis.Musteriler responsedCustomer = musteriServis.MusteriIdSec(ID);
    //                if (responsedCustomer != null)
    //                {
    //                    castedCustomer = new Musteriler()
    //                    {
    //                        MusteriId = responsedCustomer.MusteriId,
    //                        Sifre = responsedCustomer.Sifre,
    //                        KullaniciAdi = responsedCustomer.KullaniciAdi,
    //                        EhliyetYil = responsedCustomer.EhliyetYil,
    //                        EhliyetTipi = responsedCustomer.EhliyetTipi,
    //                        TcKimlik = responsedCustomer.TcKimlik,
    //                        Ad = responsedCustomer.Ad,
    //                        Soyad = responsedCustomer.Soyad,
    //                        Adres = responsedCustomer.Adres,
    //                        Telefon = responsedCustomer.Telefon,
    //                        Email = responsedCustomer.Email,
    //                        DogumTarihi = responsedCustomer.DogumTarihi,
    //                    };

    //                }

    //                return castedCustomer;
    //            }
    //        }
    //        catch (Exception ex)
    //        {
    //            throw new Exception("Customer doesn't exists.");
    //        }
    //    }
    }

}