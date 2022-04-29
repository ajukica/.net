using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Projekt.Controllers
{
    public class RacunArtikliController : Controller
    {
        Entites db = new Entites();
        // GET: RacunArtikli
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult GetRacunArtikl()
        {
            List<RacunArtikli> racunArtikli= new List<RacunArtikli>();

          
                var rezultat = (from item in db.RacunArtiklis
                                select new
                                {
                                    item.ID,
                                    item.RacunID,
                                    item.ArtikliID,
                                    item.Kolicina
                                }).ToList();

                foreach (var e in rezultat)
                {
                    racunArtikli.Add(new RacunArtikli
                    {
                        ID = e.ID,
                        RacunID = e.RacunID,
                        ArtikliID = e.ArtikliID,
                        Kolicina = e.Kolicina
                    });
                };
            
            return Json(racunArtikli, JsonRequestBehavior.AllowGet);
        }

        // Dohvatćanje artikla po ID-u
        public JsonResult GetRacunArtikliById(int id)
        {
            List<RacunArtikli> racunArtikl = new List<RacunArtikli>();

                var rezultat = (from item in db.RacunArtiklis
                                where item.ID == id
                                select new
                                {
                                    item.ID,
                                    item.RacunID,
                                    item.ArtikliID,
                                    item.Kolicina
                                   
                                }).ToList();

                foreach (var e in rezultat)
                {
                    racunArtikl.Add(new RacunArtikli
                    {
                        ID = e.ID,
                        RacunID = e.RacunID,
                        ArtikliID = e.ArtikliID,
                        Kolicina = e.Kolicina
                    });
                };
            
            return Json(racunArtikl, JsonRequestBehavior.AllowGet);
        }

        //Umetanje novog artikla
        public void NoviRacunArtikl(RacunArtikli racunArtikli)
        {
            //Try-catch blok u slucaju krivog upisa u bazu 
            try
            {
                
                    db.RacunArtiklis.Add(new RacunArtikli()
                    {
                        ID = racunArtikli.ID,
                        RacunID= racunArtikli.RacunID,  
                        ArtikliID= racunArtikli.ArtikliID,  
                        Kolicina= racunArtikli.Kolicina 
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


        public void Delete(int id)
        {
            
                RacunArtikli racunArtikl = db.RacunArtiklis.Where(x => x.ID == id).FirstOrDefault();
                db.RacunArtiklis.Remove(racunArtikl);
                db.SaveChanges();
            

        }

        //public JsonResult GetFilter(String filter)
        //{
        //    using (Database db = new Database())
        //    {
        //        var zaposlenik = db.Zaposleniks.Where(w => w.Prezime.Contains(filter)).ToList();
        //        return Json(zaposlenik, JsonRequestBehavior.AllowGet);
        //    }
        //}

        public bool Update(RacunArtikli racunArtikli)
        {
            
                var existingRacunArtikli = db.RacunArtiklis.Where(s => s.ID == racunArtikli.ID)
                                                        .FirstOrDefault<RacunArtikli>();

                if (existingRacunArtikli != null)
                {
                    existingRacunArtikli.ID = racunArtikli.ID;
                    existingRacunArtikli.RacunID = racunArtikli.ID; 
                    existingRacunArtikli.ArtikliID = racunArtikli.ID;   
                    existingRacunArtikli.Kolicina = racunArtikli.Kolicina;

                    db.SaveChanges();
                }
                else
                {
                    return false;
                }
            

            return true;
        }
    }
}