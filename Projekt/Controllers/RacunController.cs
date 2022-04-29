using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Projekt.Controllers
{
    public class RacunController : Controller
    {
        Entites db = new Entites();
        // GET: Racun
        public ActionResult Index()
        {
            return View();
        }

        //Dohvacanje svih artikala
        public JsonResult GetRacuni()
        {
            List<Racun> racuni = new List<Racun>();

          
                var rezultat = (from item in db.Racuns
                                select new
                                {
                                    item.RacunID,
                                    item.KupacID,
                                    item.ZaposlenikID,
                                    item.Brojracuna
                                }).ToList();

                foreach (var e in rezultat)
                {
                    racuni.Add(new Racun
                    {
                        RacunID = e.RacunID,
                        KupacID = e.KupacID,
                        ZaposlenikID = e.ZaposlenikID,
                        Brojracuna = e.Brojracuna
                    });
                };
            
            return Json(racuni, JsonRequestBehavior.AllowGet);
        }

        // Dohvatćanje artikla po ID-u
        public JsonResult GetRacunByID(int id)
        {
            List<Racun> racuni= new List<Racun>();

          
                var rezultat = (from item in db.Racuns
                                where item.RacunID == id
                                select new
                                {
                                    item.KupacID,
                                    item.RacunID,
                                    item.ZaposlenikID,
                                    item.Brojracuna
                                }).ToList();

                foreach (var e in rezultat)
                {
                    racuni.Add(new Racun
                    {
                        RacunID = e.RacunID,
                        KupacID = e.KupacID,
                        ZaposlenikID = e.ZaposlenikID,
                        Brojracuna = e.Brojracuna
                    });
                };
            
            return Json(racuni, JsonRequestBehavior.AllowGet);
        }

        //Umetanje novog artikla
        //public void NoviRacun(Racun racun)
        //{
        //    //Try-catch blok u slucaju krivog upisa u bazu 
        //    try
        //    {
                
        //            db.Racuns.Add(new Racun()
        //            {
        //                KupacID = racun.KupacID,
        //                ZaposlenikID = racun.ZaposlenikID,
        //                Brojracuna = racun.Brojracuna
        //            });
                  
        //            db.SaveChanges();
                   
                
        //    }
        //    catch (DbEntityValidationException e)
        //    {
        //        foreach (var eve in e.EntityValidationErrors)
        //        {
        //            Console.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
        //                eve.Entry.Entity.GetType().Name, eve.Entry.State);
        //            foreach (var ve in eve.ValidationErrors)
        //            {
        //                Console.WriteLine("- Property: \"{0}\", Error: \"{1}\"",
        //                    ve.PropertyName, ve.ErrorMessage);
        //            }
        //        }
        //        throw;
        //    }

        //}

        public void NoviRacun(Racun racun)
        {
            db.Racuns.Add(racun);
            db.SaveChanges();
        }




        public void Delete(int id)
        {
           
                Racun racun= db.Racuns.Where(x => x.RacunID == id).FirstOrDefault();
                db.Racuns.Remove(racun);
                db.SaveChanges();
            

        }

        //public JsonResult GetFilter(String filter)
        //{
        //    using (Database db = new Database())
        //    {
        //        var racuni = db.Racuns.Where(w => w.RacunID.Contains(filter)).ToList();
        //        return Json(racuni, JsonRequestBehavior.AllowGet);
        //    }
        //}

        public bool Update(Racun racun)
        {
            
                var existingRacun = db.Racuns.Where(s => s.RacunID == racun.RacunID)
                                                        .FirstOrDefault<Racun>();

                if (existingRacun != null)
                {   
                    existingRacun.RacunID = racun.RacunID;  
                    existingRacun.KupacID = racun.KupacID;  
                    existingRacun.ZaposlenikID = racun.ZaposlenikID;    
                    existingRacun.Brojracuna = racun.Brojracuna;

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