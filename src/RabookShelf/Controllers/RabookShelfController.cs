using RabookShelf.Data;
using RabookShelf.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RabookShelf.Controllers
{
    public class RabookShelfController : Controller
    {
        private Context db = new Context();

        //Get Index
        public ActionResult Index()
        {
            var books = Repository.GetBooks();
            return View(books);
        }

        //Add
        public ActionResult Add()
        {
            return View("Add");
        }

        //Add
        [HttpPost]
        public ActionResult Add(string title, string firstName, string lastName, 
                                bool? fiction, BookSize booksize, string description)
        {
            ViewBag.Title = ModelState["Title"].Value.AttemptedValue;
            ViewBag.FirstName = ModelState["FirstName"].Value.AttemptedValue;
            ViewBag.LastName = ModelState["LastName"].Value.AttemptedValue;
            ViewBag.Fiction = ModelState["Fiction"].Value.AttemptedValue;
            ViewBag.BookSize = ModelState["BookSize"].Value.AttemptedValue;
            ViewBag.Description = ModelState["Description"].Value.AttemptedValue;

            return View("Add");
        }


        //Edit

        //Delete

        //Get Entry
        public ActionResult Entry()
        {
            return View("Entry");
        }

    }
}