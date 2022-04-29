using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Projekt.Controllers
{
    public class ZaposlenikController : Controller
    {
        Entites db = new Entites();
        // GET: Zaposlenik
        public System.Web.Mvc.ActionResult Index()
        {
            return View();
        }

        //Dohvacanje svih artikala
        public JsonResult GetZaposlenik()
        {
            List<Zaposlenik> zaposlenici = new List<Zaposlenik>();

            
                var rezultat = (from item in db.Zaposleniks
                                select new
                                {
                                    item.ZaposlenikID,
                                    item.Ime,
                                    item.Prezime
                                }).ToList();

                foreach (var e in rezultat)
                {
                    zaposlenici.Add(new Zaposlenik
                    {
                        ZaposlenikID = e.ZaposlenikID,
                        Ime = e.Ime,
                        Prezime = e.Prezime
                    });
                };
            
            return Json(zaposlenici, JsonRequestBehavior.AllowGet);
        }

        // Dohvatćanje artikla po ID-u
        public JsonResult GetZaposlenikById(int id)
        {
            List<Zaposlenik> zaposlenik = new List<Zaposlenik>();

          
                var rezultat = (from item in db.Zaposleniks
                                where item.ZaposlenikID == id
                                select new
                                {
                                    item.ZaposlenikID,
                                    item.Ime,
                                    item.Prezime
                                }).ToList();

                foreach (var e in rezultat)
                {
                    zaposlenik.Add(new Zaposlenik
                    {
                        ZaposlenikID = e.ZaposlenikID,
                        Ime = e.Ime,
                        Prezime = e.Prezime
                    });
                };
            
            return Json(zaposlenik, JsonRequestBehavior.AllowGet);
        }

        //Umetanje novog artikla
        public void NoviZaposlenik(Zaposlenik zaposlenik)
        {
            //Try-catch blok u slucaju krivog upisa u bazu 
            try
            {
               
                    db.Zaposleniks.Add(new Zaposlenik()
                    {
                        ZaposlenikID = zaposlenik.ZaposlenikID,
                        Ime = zaposlenik.Ime,
                        Prezime = zaposlenik.Prezime
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



        public void Delete(int id)
        {
            
                Zaposlenik zaposlenik = db.Zaposleniks.Where(x => x.ZaposlenikID == id).FirstOrDefault();
                db.Zaposleniks.Remove(zaposlenik);
                db.SaveChanges();
            

        }

        public JsonResult GetFilter(String filter)
        {
           
                var zaposlenik = db.Zaposleniks.Where(w => w.Prezime.Contains(filter)).ToList();
                return Json(zaposlenik, JsonRequestBehavior.AllowGet);
            
        }

        public bool Update(Zaposlenik zaposlenik)
        {
              var existingZaposlenik = db.Zaposleniks.Where(s => s.ZaposlenikID == zaposlenik.ZaposlenikID)
                                                        .FirstOrDefault<Zaposlenik>();

                if (existingZaposlenik != null)
                {
                    existingZaposlenik.ZaposlenikID = zaposlenik.ZaposlenikID;
                    existingZaposlenik.Ime = zaposlenik.Ime;
                    existingZaposlenik.Prezime = zaposlenik.Prezime;

                    db.SaveChanges();
                }
                else
                {
                    return false;
                }
            

            return true;
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
    }
}