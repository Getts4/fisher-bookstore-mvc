using System;
using Microsoft.AspNetCore.Mvc;
using Fisher.Bookstore.Models;

namespace Fisher.Bookstore.Controllers
{
    public class AuthorsController : Controller
    {
        public IActionResult Index()
        {
            return View(); 
        }
        public IActionResult Featured()
        {
            // we would normally get this from a database
            var featuredAuthor = new Author()
            {
                AuthorId = 1,
                Name = "J.D. Salinger"
                };
                return View(featuredAuthor);
        }
        
    }
}