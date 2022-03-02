using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore_API.Controllers
{
    public class BooksController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
