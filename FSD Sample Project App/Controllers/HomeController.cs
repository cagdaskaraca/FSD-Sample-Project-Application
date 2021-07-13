using FSD_Sample_Project_App.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FSD_Sample_Project_App.Controllers
{
    public class HomeController : Controller
    {

        FSDSampleProjectdbEntities1 db = new FSDSampleProjectdbEntities1();
        public ActionResult Index(string ara)
        {
            var model = db.FSDSampleProjectdb.ToList();
            if (!string.IsNullOrEmpty(ara))
            {
                model = model.Where(x => x.KisaAd.Contains(ara) || x.Ad.Contains(ara)).ToList();
            }
            return View(model);
        }
        public ActionResult Ekle()
        {
            return View();
        }
        public ActionResult Ekle2(FSDSampleProjectdb k)
        {
            db.FSDSampleProjectdb.Add(k);
            db.SaveChanges();
            return RedirectToAction("Index");

        }
        public ActionResult GuncelleBilgiGetir(FSDSampleProjectdb k)
        {
            var model = db.FSDSampleProjectdb.Find(k.Id);
            if (model == null) return HttpNotFound();
            return View(model);

        }
        public ActionResult Guncelle(FSDSampleProjectdb k)
        {
            db.Entry(k).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");


        }
        public ActionResult SilBilgiGetir(FSDSampleProjectdb k)
        {
            var model = db.FSDSampleProjectdb.Find(k.Id);
            if (model == null) return HttpNotFound();
            return View(model);

        }
        public ActionResult Sil(FSDSampleProjectdb k)
        {
            db.Entry(k).State = System.Data.Entity.EntityState.Deleted;
            db.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}