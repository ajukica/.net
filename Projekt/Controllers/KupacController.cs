using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Projekt.Controllers
{
    public class KupacController : Controller
    {
        Entites db = new Entites();

        public ActionResult Index()
        {
            return View();
        }

        //Dohvacanje svih artikala
        public JsonResult GetKupac()
        {
            List<Kupac> kupci = new List<Kupac>();

            
                var rezultat = (from item in db.Kupacs
                                select new
                                {
                                    item.KupacID,
                                    item.Ime,
                                    item.Prezime,                     
                                }).ToList();

                foreach (var e in rezultat)
                {
                    kupci.Add(new Kupac
                    {
                        KupacID = e.KupacID,
                        Ime = e.Ime,
                        Prezime = e.Prezime
                    });
                };
            
            return Json(kupci, JsonRequestBehavior.AllowGet);
        }

        // Dohvatćanje artikla po ID-u
        public JsonResult GetKupacById(int id)
        {
            List<Kupac> kupci = new List<Kupac>();

            
                var rezultat = (from item in db.Kupacs
                                where item.KupacID == id
                                select new
                                {
                                    item.KupacID,
                                    item.Ime,
                                    item.Prezime
                                }).ToList();

                foreach (var e in rezultat)
                {
                    kupci.Add(new Kupac
                    {
                        KupacID = e.KupacID,
                        Ime = e.Ime,
                        Prezime = e.Prezime
                    });
                };
            
            return Json(kupci, JsonRequestBehavior.AllowGet);
        }

        //Umetanje novog artikla
        public void NoviKupac(Kupac kupci)
        {
            //Try-catch blok u slucaju krivog upisa u bazu 
            try
            {
                
                    db.Kupacs.Add(new Kupac()
                    {
                        Ime = kupci.Ime,
                        Prezime = kupci.Prezime,
                        KupacID = kupci.KupacID
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

            Kupac kupci = db.Kupacs.Where(x => x.KupacID == id).FirstOrDefault();
               db.Kupacs.Remove(kupci);
               db.SaveChanges();
            

        }

        public JsonResult GetFilter(String filter)
        {
          
                var kupci = db.Kupacs.Where(w => w.Prezime.Contains(filter)).ToList();
                return Json(kupci, JsonRequestBehavior.AllowGet);
            
        }

        public bool Update(Kupac  kupac)
        {
            
                var existingKupac = db.Kupacs.Where(s => s.KupacID == kupac.KupacID)
                                                        .FirstOrDefault<Kupac>();

                if (existingKupac != null)
                {   
                    existingKupac.KupacID = kupac.KupacID;  
                    existingKupac.Ime = kupac.Ime;  
                    existingKupac.Prezime = kupac.Prezime;  

                    db.SaveChanges();
                }
                else
                {
                    return false;
                }
            

            return true;
        }

        public string GetKupacByName()
        {
            
                var kupci = new List<Kupac>();
                kupci = db.Kupacs.ToList<Kupac>();

                var kupac = new Dictionary<int, string>();

                foreach (var kup in kupci)
                {
                    kupac.Add(kup.KupacID, kup.Prezime);
                }
                return JsonConvert.SerializeObject(kupac);
            
        }
    }
}
