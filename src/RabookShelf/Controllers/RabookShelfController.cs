using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RabookShelf.Controllers
{
    public class RabookShelfController : Controller
    {   
        public ActionResult Entry()
        {
            return View("Entry");
           
        }

        //public ActionResult Index()
        //{
        //    return View("Index");
        //}
    }
}