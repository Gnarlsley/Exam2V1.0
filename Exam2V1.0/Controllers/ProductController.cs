using Exam2V1._0.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Exam2V1._0.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Product()
        {
            return View();
        }
    }
}
