using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Commons.Concretes;
using Business.Concretes;

namespace RentaCarWeb.Controllers
{
    public class AracController : Controller
    {
        
        // GET: Arac
        public ActionResult Index()
        {
            return View();
        }


        // GET: Customer/Details/5
        public ActionResult Detay(int id)
        {
            return View();
        }

        // GET: Customer/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Customer/Create
        [HttpPost]

        public ActionResult Create(FormCollection collection)
        {
         
                return View();
            
          
        }

        public ActionResult AracListesi()
        {
            return View();
        }

        public ActionResult AracEkle()
        {
            return View();
        }
        public ActionResult AracDetay(int id)
        {
            ViewBag.aracId = id;
            return View();
        }
       


        //private bool AracEkle(string aracadi, int arackm, string aracmodeli, int bagajhacmi, int gerekenehliyetyasi, int gunlukkirabedeli,
        //    int gunlukkmsinir, int koltuksayisi, int minyassiniri, string plaka, string havayastigi, string yakittipi, string vitestipi)
        //{
        //    bool success=false;
        //    var message = "";
        //    try
        //    {
        //        using (var aracServis = new AracWebServis.AracWebServisSoapClient())
        //        {
        //            var arac=  new AracWebServis.Araclar()
        //            {
        //                AracAdi = aracadi,
        //                AracKm = arackm,
        //                AracModeli = aracmodeli,
        //                BagajHacmi = bagajhacmi,
        //                GerekenEhliyetYasi = gerekenehliyetyasi,
        //                GunlukKiraBedeli = gunlukkirabedeli,
        //                GunlukKmSiniri = gunlukkmsinir,
        //                KoltukSayisi = koltuksayisi,
        //                MinimumYasSiniri = minyassiniri,
        //                Plaka = plaka,
        //                HavaYastigi = havayastigi,
        //                YakitTipi = yakittipi,
        //                VitesTipi = vitestipi,
        //                SirketId=2
        //            };

        //            using (var sirketServis = new SirketWebServis.SirketWebServisSoapClient())
        //            {
        //                foreach (var item in sirketServis.SirketHepsiniSec())
        //                {
        //                    if(item.SirketId == 2)
        //                    {
        //                        var sirket = new AracWebServis.Sirket()
        //                        {
        //                            SirketAdi = item.SirketAdi,
        //                            SirketId = item.SirketId,
        //                            Sehir = item.Sehir,
        //                            SirketPuani = item.SirketPuani,
        //                            Adres = item.Adres,
        //                            AracSayisi = item.AracSayisi + 1
        //                        };
        //                        success = aracServis.AracEkle(arac, sirket);
        //                    }
        //                }
        //                message = success ? "done" : "failed";

        //            }
                   
        //        }
                

        //        //MÜŞTERİNİN EKLENİP EKLENMEDİĞİ KONTROL EDİLİR
        //        return success;
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception("Customer doesn't exists.");
        //    }
        //}
        //public List<Arac> aracGetir()
        //{

        //    try
        //    {
        //        using (var aracServis = new AracWebServis.AracWebServisSoapClient())
        //        {
        //            List<Arac> araclar = new List<Arac>();
        //            foreach (var cevaplayanArac in aracServis.AracHepsiniSec().OrderBy(x => x.AracId)
        //                .ToList())
        //            {
        //                Arac arac = new Arac()
        //                {
        //                    AracAdi = cevaplayanArac.AracAdi,
        //                    AracKm = cevaplayanArac.AracKm,
        //                    AracModeli = cevaplayanArac.AracModeli,
        //                    BagajHacmi = cevaplayanArac.BagajHacmi,
        //                    GerekenEhliyetYasi = cevaplayanArac.GerekenEhliyetYasi,
        //                    GunlukKiraBedeli = cevaplayanArac.GunlukKiraBedeli,
        //                    GunlukKmSiniri = cevaplayanArac.GunlukKmSiniri,
        //                    KoltukSayisi = cevaplayanArac.KoltukSayisi,
        //                    MinimumYasSiniri = cevaplayanArac.MinimumYasSiniri,
        //                    Plaka = cevaplayanArac.Plaka,
        //                    HavaYastigi = cevaplayanArac.HavaYastigi,
        //                    YakitTipi = cevaplayanArac.YakitTipi,
        //                    VitesTipi = cevaplayanArac.VitesTipi,
        //                    AracId=cevaplayanArac.AracId,
        //                    AracResmi=cevaplayanArac.AracResmi,
        //                    Kirada=cevaplayanArac.Kirada,
        //                    KiradanDonusTarihi=cevaplayanArac.KiradanDonusTarihi,
        //                    KiralanmaTarihi=cevaplayanArac.KiralanmaTarihi,
        //                    MusteriId=cevaplayanArac.MusteriId,
        //                    Rezerv=cevaplayanArac.Rezerv,
        //                    SirketId=cevaplayanArac.SirketId
        //                };

        //                araclar.Add(arac);
        //            }
        //            return araclar;

        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}

        //private bool AracGuncelle(string aracadi, int arackm, string aracmodeli, int bagajhacmi, int gerekenehliyetyasi, int gunlukkirabedeli,
        //    int gunlukkmsinir, int koltuksayisi, int minimumyassiniri, string plaka, string havayastigi, string vitestipi, string yakittipi)
        //{

        //    bool success = false;
        //    try
        //    {

        //        List<Arac> araclar = new List<Arac>();
        //        araclar = aracGetir();

        //        using (var aracServis = new AracWebServis.AracWebServisSoapClient())
        //        {
        //            foreach (var item in araclar)
        //            {
        //                if (plaka == item.Plaka)
        //                {
        //                    success = aracServis.AracEkle(new AracWebServis.Araclar()
        //                    {
        //                        AracAdi = aracadi,
        //                        AracKm = arackm,
        //                        AracModeli = aracmodeli,
        //                        BagajHacmi = bagajhacmi,
        //                        GerekenEhliyetYasi = gerekenehliyetyasi,
        //                        GunlukKiraBedeli = gunlukkirabedeli,
        //                        GunlukKmSiniri = gunlukkmsinir,
        //                        KoltukSayisi = koltuksayisi,
        //                        MinimumYasSiniri = minimumyassiniri,
        //                        Plaka = plaka,
        //                        HavaYastigi = havayastigi,
        //                        YakitTipi = yakittipi,
        //                        VitesTipi = vitestipi,

        //                    });
        //                    var message = success ? "done" : "failed";
        //                }

        //            }

        //            //MÜŞTERİNİN EKLENİP EKLENMEDİĞİ KONTROL EDİLİR
        //            return success;
        //        }
        //    }
        //    catch (Exception ex)
        //    {

        //        throw ex;
        //    }

        //}

       
        //private Arac IdSec(int ID)
        //{
        //    try
        //    {
        //        using (var aracServis = new AracWebServisSoapClient())
        //        {
        //            Arac castedCustomer = null;
        //            AracWebServis.Araclar responsedCustomer = aracServis.AracIdSec(ID);
        //            if (responsedCustomer != null)
        //            {
        //                castedCustomer = new Arac()
        //                {
        //                    AracAdi = responsedCustomer.AracAdi,
        //                    AracKm = responsedCustomer.AracKm,
        //                    AracModeli = responsedCustomer.AracModeli,
        //                    BagajHacmi = responsedCustomer.BagajHacmi,
        //                    GerekenEhliyetYasi = responsedCustomer.GerekenEhliyetYasi,
        //                    GunlukKiraBedeli = responsedCustomer.GunlukKiraBedeli,
        //                    GunlukKmSiniri = responsedCustomer.GunlukKmSiniri,
        //                    KoltukSayisi = responsedCustomer.KoltukSayisi,
        //                    MinimumYasSiniri = responsedCustomer.MinimumYasSiniri,
        //                    Plaka = responsedCustomer.Plaka,
        //                    HavaYastigi = responsedCustomer.HavaYastigi,
        //                    YakitTipi = responsedCustomer.YakitTipi,
        //                    VitesTipi = responsedCustomer.VitesTipi,
        //                };

        //            }

        //            return castedCustomer;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception("Customer doesn't exists.");
        //    }
        //}





    }
}  