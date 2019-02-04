using System;
using Microsoft.AspNetCore.Mvc;

namespace Fisher.Bookstore.Controllers
{
    public class BooksController : Controller
    {
        public IActionResult Index()
        {
            return Content("This is the Book controller’s Index action");
        }
        public IActionResult New()
        {
            return Content("This is the Book controller’s New action");
        }
        [Route("books/best-sellers")]
        public IActionResult BestSellers()
        {
            return Content("This is the Book controller's best-sellers action");
        }
    }
}