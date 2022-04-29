using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Projekt.Controllers
{
    public class KategorijaController : Controller
    {
        Entites db = new Entites();
        // GET: Kategorija
        public ActionResult Index()
        {
            return View();
        }

        //Dohvacanje svih artikala
        public JsonResult GetKategorija()
        {
            List<Kategorija> kategorije = new List<Kategorija>();


            {
                var rezultat = (from item in db.Kategorijas
                                select new
                                {
                                    item.KategorijaID,
                                    item.Naziv
                                }).ToList();

                foreach (var e in rezultat)
                {
                    kategorije.Add(new Kategorija
                    {
                        KategorijaID = e.KategorijaID,
                        Naziv = e.Naziv
                    });
                };
            }
            return Json(kategorije, JsonRequestBehavior.AllowGet);
        }

        // Dohvatćanje artikla po ID-u
        public JsonResult GetKategorijaById(int id)
        {
            List<Kategorija> kategorije = new List<Kategorija>();


            {
                var rezultat = (from item in db.Kategorijas
                                where item.KategorijaID == id
                                select new
                                {
                                    item.KategorijaID,
                                    item.Naziv
                                }).ToList();

                foreach (var e in rezultat)
                {
                    kategorije.Add(new Kategorija
                    {
                        Naziv = e.Naziv,
                        KategorijaID = e.KategorijaID
                    });
                };
            }
            return Json(kategorije, JsonRequestBehavior.AllowGet);
        }

        //Umetanje novog artikla
        public void NovaKategorija(Kategorija kategorija)
        {
            //Try-catch blok u slucaju krivog upisa u bazu 
            try
            {
                {
                    db.Kategorijas.Add(new Kategorija()
                    {
                        Naziv = kategorija.Naziv,
                        KategorijaID = kategorija.KategorijaID
                    });

                    db.SaveChanges();
                }
            }
            catch (DbEntityValidationException e)
            {
                foreach (var eve in e.EntityValidationErrors)
                {
                    Console.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                        eve.Entry.Entity.GetType().Name, eve.Entry.State);
                    foreach (var ve in eve.ValidationErrors)
                    {
                        Console.WriteLine("- Property: \"{0}\", Error: \"{1}\"",
                            ve.PropertyName, ve.ErrorMessage);
                    }
                }
                throw;
            }

        }

        //public void NoviArtikl(Artikli artikli)
        //{
        //    using (Database db = new Database())
        //    {
        //        db.Artiklis.Add(artikli);
        //        db.SaveChanges();
        //    }
        //}


        public void Delete(int id)
        {


            Kategorija kategorija = db.Kategorijas.Where(x => x.KategorijaID == id).FirstOrDefault();
            db.Kategorijas.Remove(kategorija);
            db.SaveChanges();


        }

        public JsonResult GetFilter(String filter)
        {

            var kategorija = db.Kategorijas.Where(w => w.Naziv.Contains(filter)).ToList();
            return Json(kategorija, JsonRequestBehavior.AllowGet);

        }

        public bool Update(Kategorija kategorija)
        {

            var existingKategorija = db.Kategorijas.Where(s => s.KategorijaID == kategorija.KategorijaID)
                                                    .FirstOrDefault<Kategorija>();

            if (existingKategorija != null)
            {
                existingKategorija.KategorijaID = kategorija.KategorijaID;
                existingKategorija.Naziv = kategorija.Naziv;

                db.SaveChanges();
            }
            else
            {
                return false;
            }
            return true;
        }

        public string GetName()
        {        
                var kategorije = new List<Kategorija>();
                kategorije = db.Kategorijas.ToList<Kategorija>();

                var kategorija = new Dictionary<int, string>();

                foreach (var k in kategorije)
                {
                    kategorija.Add(k.KategorijaID, k.Naziv);
                }
             return JsonConvert.SerializeObject(kategorija);

        }



    }
}
