using RabookShelf.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RabookShelf.Controllers
{
    public class RabookShelfController : Controller
    {
        private BookRepository _bookRepository = null;

        public RabookShelfController()
        {
            _bookRepository = new BookRepository();
        }

        //Get Entry
        public ActionResult Entry()
        {
            return View("Entry");  
        }

        //Get Index
        //public ActionResult Index()
        //{
        //    var books = _bookRepository.GetBooks();
        //    return View(books);
        //}

    }

    //public ActionResult Index()
    //    {
    //        var books = _bookRepository.GetBooks();

    //        return View(books);
    //    }


        //public ActionResult Detail(int? id)
        //{
        //    if (id == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    //id.Value below used to get at underlying value when using nullable type
        //    var comicBook = _comicBookRepository.GetComicBook(id.Value);

        //    return View(comicBook);
        //}
    
}