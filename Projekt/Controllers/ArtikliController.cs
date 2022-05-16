
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Validation;
using System.Linq;
using System.Web.Mvc;

namespace Projekt.Controllers
{
    public class ArtikliController : Controller
    {
        Entites db = new Entites();

        public ActionResult Index()
        {
            return View();
        }

        //Dohvacanje svih artikala
        public JsonResult GetArtikli()
        {
            List<Artikli> artikli = new List<Artikli>();

                var rezultat = (from item in db.Artiklis
                                select new
                                {
                                     item.ArtikliID,
                                     item.Naziv,
                                     item.Cijena,
                                     item.KategorijaID
                                }).ToList();

                foreach (var e in rezultat)
                {
                    artikli.Add(new Artikli
                    {
                        ArtikliID = e.ArtikliID,
                        Cijena = e.Cijena,
                        Naziv = e.Naziv,
                        KategorijaID = e.KategorijaID
                    });
                };
            
            return Json(artikli,JsonRequestBehavior.AllowGet);
        }

        // Dohvatćanje artikla po ID-u
        public JsonResult GetArtikliById(int id)
        {
            List<Artikli> artikli = new List<Artikli>();

           
                var rezultat = (from item in db.Artiklis where item.ArtikliID == id
                                select new
                                {
                                    item.ArtikliID,
                                    item.Naziv,
                                    item.Cijena,
                                    item.KategorijaID
                                }).ToList();

                foreach (var e in rezultat)
                {
                    artikli.Add(new Artikli
                    {
                        ArtikliID = e.ArtikliID,
                        Cijena = e.Cijena,
                        Naziv = e.Naziv,
                        KategorijaID = e.KategorijaID
                    });
                };
            
            return Json(artikli, JsonRequestBehavior.AllowGet);
        }

        //Umetanje novog artikla
        public void NoviArtikl(Artikli artikli)
        {
            //Try-catch blok u slucaju krivog upisa u bazu 
            try
            {
             
                    db.Artiklis.Add(new Artikli()
                    {
                        Naziv = artikli.Naziv,
                        Cijena = artikli.Cijena,
                        KategorijaID = artikli.KategorijaID
                    });

                    db.SaveChanges();
                
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

        //Brisanje artikla
        public void Delete(int id)
        {
                Artikli artikli = db.Artiklis.Where(x => x.ArtikliID == id).FirstOrDefault();
                db.Artiklis.Remove(artikli);
                db.SaveChanges();



        }

        public JsonResult GetFilter(String filter)
        {
                var artikli = db.Artiklis.Where(w => w.Naziv.Contains(filter)).ToList();
                return Json(artikli,JsonRequestBehavior.AllowGet);
            
        }

        //Potrebno testirati
        public bool Update(Artikli artikli)
        {
           
                var existingArtikli = db.Artiklis.Where(s => s.ArtikliID == artikli.ArtikliID)
                                                        .FirstOrDefault<Artikli>();

                if (existingArtikli != null)
                {
                    existingArtikli.ArtikliID = artikli.ArtikliID; 
                    existingArtikli.Naziv = artikli.Naziv;
                    existingArtikli.Cijena = artikli.Cijena;
                    existingArtikli.KategorijaID = artikli.KategorijaID;

                    db.SaveChanges();
                }
                else
                {
                    return false;
                }
            

            return true;
        }

        public string GetArtiklKategorija(int id)
        {
           
                var sviArtikli = new List<Artikli>();
                sviArtikli = db.Artiklis.ToList();

                var artikli = new Dictionary<int, string>();

                foreach (var a in sviArtikli)
                {
                    var query = (from row in db.Artiklis where row.KategorijaID == id select row).ToList();
                     artikli.Add(a.ArtikliID, a.Naziv);
                }

         return JsonConvert.SerializeObject(artikli);

        }

        public string GetZaposlenikByName()
        {

            var zapolenici = new List<Zaposlenik>();
            zapolenici = db.Zaposleniks.ToList<Zaposlenik>();

            var zaposlenik = new Dictionary<int, string>();

            foreach (var zap in zapolenici)
            {
                zaposlenik.Add(zap.ZaposlenikID, zap.Prezime);
            }
            return JsonConvert.SerializeObject(zaposlenik);

        }

        public string GetCijena()
        {
                var Artikli = new List<Artikli>();
                Artikli = db.Artiklis.ToList();

                var artikl = new Dictionary<string, decimal>();

                foreach (var a in Artikli)
                {
                    artikl.Add(a.Naziv, a.Cijena);
                }

            return JsonConvert.SerializeObject(artikl);

        }

        public string GetID()
        {          
                var Artikli = new List<Artikli>();
                Artikli = db.Artiklis.ToList();

                var artikl = new Dictionary<string, int>();

                foreach (var a in Artikli)
                {
                    artikl.Add(a.Naziv, a.ArtikliID);
                }

            return JsonConvert.SerializeObject(artikl);

        }
    }
    
}





