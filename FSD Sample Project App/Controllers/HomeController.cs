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

        FSDSampleProjectdbEntities db = new FSDSampleProjectdbEntities();
        public ActionResult Index(string ara)
        {
            var model = db.Urun.ToList();
            if (!string.IsNullOrEmpty(ara))
            {
                model = model.Where(x => x.KlinikAdi.Contains(ara) || x.EkipmanAdi.Contains(ara)).ToList();
            }
            return View(model);
        }
        public ActionResult Ekle()
        {
            return View();
        }
        public ActionResult Ekle2(Urun k)
        {
            db.Urun.Add(k);
            db.SaveChanges();
            return RedirectToAction("Index");

        }
        public ActionResult GuncelleBilgiGetir(Urun k)
        {
            var model = db.Urun.Find(k.ID);
            if (model == null) return HttpNotFound();
            return View(model);

        }
        public ActionResult Guncelle(Urun k)
        {
            db.Entry(k).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");


        }
        public ActionResult SilBilgiGetir(Urun k)
        {
            var model = db.Urun.Find(k.ID);
            if (model == null) return HttpNotFound();
            return View(model);

        }
        public ActionResult Sil(Urun k)
        {
            db.Entry(k).State = System.Data.Entity.EntityState.Deleted;
            db.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}