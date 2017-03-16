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

            ViewBag.GenresSelectListItems = new SelectList(context.Books, "Id", "Name" );

            return View(book);

        }

        //Add
        [HttpPost]
        public ActionResult Add(Book book)
        {   
            if (ModelState.IsValid)
            {
                
                Repository.AddBook(book);

                //TODO redirect to index (to see the book just added);
                return RedirectToAction("Index");
            }

            ViewBag.GenresSelectListItems = new SelectList(context.Genres, "Id", "Name");
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