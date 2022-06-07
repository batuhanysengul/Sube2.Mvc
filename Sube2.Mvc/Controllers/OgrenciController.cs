using Microsoft.AspNetCore.Mvc;
using Sube2.Mvc.Models;
using System.Collections.Generic;
using System.Linq;

namespace Sube2.Mvc.Controllers
{
    public class OgrenciController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult OgrenciEkle()
        {
            return View();
        }

        [HttpPost]
        public IActionResult OgrenciEkle(Ogrenci ogr)
        {
            if (ogr != null)
            {
                using (var ctx = new OkulDbContext())
                {
                    ctx.Ogrenciler.Add(ogr);
                    ctx.SaveChanges();
                }
            }
            return View();
        }

        public IActionResult OgrenciListe()
        {
            List<Ogrenci> lst = null;
            using (var ctx = new OkulDbContext())
            {
                lst = ctx.Ogrenciler.ToList();
            }
            return View(lst);
        }

        //--------------------------------------------------------------------------------------/
         
        [HttpPost]
        public IActionResult OgrenciSil(int id)
        {
            if (id != 0)
            {
                using (var ctx = new OkulDbContext())
                {
                    var ogrenci = ctx.Ogrenciler.Find(id);
                    ctx.Remove(ogrenci);

                    ctx.SaveChanges();
                }
            }
            return RedirectToAction("OgrenciListe");
        }


        public IActionResult OgrenciDuzenle(int id)
        {
            using (var ctx = new OkulDbContext())
            {
                return View(ctx.Ogrenciler.Find(id));
            }
        }

        [HttpPost]
        public IActionResult OgrenciDuzenle(Ogrenci ogrenci)
        {
            using (var ctx = new OkulDbContext())
            {
                ctx.Ogrenciler.Update(ogrenci);
                ctx.SaveChanges();
            }
            return RedirectToAction("OgrenciListe");
        }
    }
}
