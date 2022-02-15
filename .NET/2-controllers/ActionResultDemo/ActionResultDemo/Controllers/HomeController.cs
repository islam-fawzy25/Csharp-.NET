using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ActionResultDemo.Controllers
{
    [Authorize]  // filter  -- Logging -- caching -- Authorization ---
    public class HomeController : Controller
    {
        [AllowAnonymous]
        //public ActionResult Index()
        //{
        //    return View();
        //}
        //public string Index()
        //{
        //    return "<h2> home controller - Index Action has sent this text </h2> ";
        //}
        //public ActionResult Index()
        //{
        //    return Content("<h2> home controller - Index Action has sent this text </h2> ");
        //}

        //public ActionResult Index()
        //{
        //    return File("web.config", "xml");
        //}
        //public ActionResult Index()
        //{
        //    var personer = new List<Person> { 
        //        new Person {FirstName = "Ham", LastName ="Der", City= "NogenHavn"},
        //        new Person {FirstName = "Ham", LastName ="Der", City= "NogenHavn"},
        //        new Person {FirstName = "Ham", LastName ="Der", City= "NogenHavn"},
        //        new Person {FirstName = "Ham", LastName ="Der", City= "NogenHavn"},
        //        new Person {FirstName = "Ham", LastName ="Der", City= "NogenHavn"},
        //        new Person {FirstName = "Ham", LastName ="Der", City= "NogenHavn"},
        //        new Person {FirstName = "Ham", LastName ="Der", City= "NogenHavn"}
        //    };
        //    return Json(personer, JsonRequestBehavior.AllowGet);
        //}
        public ActionResult Index()
        {
            //return RedirectToAction("Contact");
            //return RedirectToAction("Register", "Account"); // Action in another Controller
            //return RedirectToRoute(new { Controller = "Account" , Action = "Login" });
            return Redirect("https://dmi.dk");
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}