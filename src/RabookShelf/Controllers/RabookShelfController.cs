using RabookShelf.Data;
using RabookShelf.Models;
using System.Net;
using System.Web.Mvc;

namespace RabookShelf.Controllers
{
    public class RabookShelfController : Controller
    {
        private Context context = new Context();

        //Get Index
        public ActionResult Index()
        {
            var books = Repository.GetBooks();
            return View(books);
        }

        //Add
        public ActionResult Add()
        {
            var book = new Book();

            return View(book);

        }

        //Add
        [HttpPost]
        public ActionResult Add(Book book)
        {
            //If there arent any Title field validation errors then make sure that the title
            //is not an empty string.
            ValidateTitle(book);

            if (ModelState.IsValid)
            {
                Repository.AddBook(book);
                //TODO redirect to index (to see the book just added);
                return RedirectToAction("Index");
            }

            return View(book);
        }

        //Edit
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
           
            Book book = Repository.GetABook((int)id);

            if (book == null)
            {
                return new HttpNotFoundResult();
            }


            return View(book);
        }

        //Edit post action method
        [HttpPost]
        public ActionResult Edit(Book book)
        {
            ValidateTitle(book);
        
            if (ModelState.IsValid)
            {
                Repository.UpdateBook(book);

                return RedirectToAction("Index");
            }

            //TODO Populate the genres select list items ViewBag property
           
            return View(book);
        }

        //Delete
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Book book = Repository.GetABook((int)id);

            if (book == null)
            {
                return new HttpNotFoundResult();
            }

            return View(book);
        }

        //create delete POST action method.  This method only needs an id not a whole model.
        [HttpPost]
        public ActionResult Delete(int id)
        {           
            Repository.Delete(id);
        
            return RedirectToAction("Index");       
        }

        private void ValidateTitle(Book book)
        {
            if (ModelState.IsValidField("Title") && book.Title == null)
            {
                ModelState.AddModelError("Title", "Please give the book a Title.");
            }
        }
    }
}