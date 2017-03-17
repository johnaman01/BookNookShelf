using RabookShelf.Data;
using RabookShelf.Models;
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
            //ModelState.AddModelError("", "The form has detected the following errors:");

            //If there arent any Title field validation errors then make sure that the title
            //is not an empty string.
            if (ModelState.IsValidField("Title") && book.Title == null)
            {
                ModelState.AddModelError("Title", "Please give the book a Title.");
            }

            if (ModelState.IsValid)
            {           
                Repository.AddBook(book);
                //TODO redirect to index (to see the book just added);
                return RedirectToAction("Index");
            }

            return View(book);
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