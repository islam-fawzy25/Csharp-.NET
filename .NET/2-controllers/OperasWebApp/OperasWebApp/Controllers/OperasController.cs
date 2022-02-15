using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using OperasWebApp.Models;
using System.Data.Entity;

namespace OperasWebApp.Controllers
{
    public class OperasController : Controller
    {
       private OperasDB db = new OperasDB();

        // GET: Operas
        public ActionResult Index()  // method in controller is called ACTION
        {
            //var AllOperas = db.Operas.ToList();
            //return View("Index", AllOperas);
            //return View(AllOperas);
            // return View("Index", db.Operas.ToList());
            ViewBag.BlaBlaMessage = "Hej med jer!";   //ViewData["BlaBlaMessage"] = "Hej med jer!";
            return View(db.Operas.ToList());
        }
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Opera op = db.Operas.Find(id); // Select * from Operas where OperaId = id;
            if (op == null)
            {
                return HttpNotFound();
            }
            return View(op);
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Opera newOpera)
        {
            if (ModelState.IsValid)
            {
                db.Operas.Add(newOpera);
                db.SaveChanges();
                //return View("Index", db.Operas.ToList());
                return RedirectToAction("Index");
            }
            return View();
        }

        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Opera operatoBeEdited = db.Operas.Find(id); // Select * from Operas where OperaId = id;
            if (operatoBeEdited == null)
            {
                return HttpNotFound();
            }
            return View(operatoBeEdited);
        }

        [HttpPost]
        public ActionResult Edit(Opera operatoBeEdited)
        {
            if (ModelState.IsValid)
            {
                db.Entry(operatoBeEdited).State = EntityState.Modified;
                db.SaveChanges();              
                return RedirectToAction("Index");
            }
            return View();
        }
        [HttpGet]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Opera operaToBeDeleted = db.Operas.Find(id); // Select * from Operas where OperaId = id;
            if (operaToBeDeleted == null)
            {
                return HttpNotFound();
            }
            return View(operaToBeDeleted);
        }
        [HttpPost , ActionName("Delete")]
        public ActionResult DeleteConfirmed(int? id)
        {
            Opera operaToBeDeleted = db.Operas.Find(id);
            db.Operas.Remove(operaToBeDeleted);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}