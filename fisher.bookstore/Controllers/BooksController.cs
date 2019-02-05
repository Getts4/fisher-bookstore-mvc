using System;
using Microsoft.AspNetCore.Mvc;

namespace Fisher.Bookstore.Controllers
{
    [Route("books")]
    public class BooksController : Controller
    {
        [Route("")]
        [Route("index")]
        public IActionResult Index()
        {
            return View();
            return Content("This is the Book controller’s Index action");
        }
        [Route("new")]
        public IActionResult New()
        {
            return View();
            return Content("This is the Book controller’s New action");
        }
        [Route("best-sellers")]
        public IActionResult BestSellers()
        {            
            return View();
            return Content("This is the Book controller's best-sellers action");
        }
    }
}