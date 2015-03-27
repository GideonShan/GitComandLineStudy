using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using StudyMVC4.Models;
using Newtonsoft.Json;
using System.Web.Helpers;



namespace StudyMVC4.Controllers
{
    public class PersonController : Controller
    {
        //
        // GET: /Person/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult TestJson()
        {
            return Json(new
            {
                Name = "Gideon",
                Age = "36"
            }
            , JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetPerson()
        {
            return Json(new Person() { Name = "Gideon", Age = "36" }, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult UpdatePerson()
        {
            string josnString = Request.Form[0];
            Person objPerson = JsonConvert.DeserializeObject<Person>(josnString);
            return Json(objPerson);
        }


        public ActionResult GetServerInfo()
        {
            return Json(new 
            { 
                serverTime= DateTime.Now.ToString() ,
                numUsers = "1"
            }, JsonRequestBehavior.AllowGet);
        }

    }
}
