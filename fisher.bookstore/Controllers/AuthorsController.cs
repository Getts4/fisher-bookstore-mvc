using System;
using Microsoft.AspNetCore.Mvc;

namespace Fisher.Bookstore.Controllers
{
    public class AuthorsController : Controller
    {
        public IActionResult Index()
        {
            return View();
            return Content("This is the Author controller’s Index action");
        }
        public IActionResult Featured()
        {
            return View();
            return Content("This is the Authors controller’s Featured action");
        }
        
    }
}