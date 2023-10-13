using Exam2V1._0.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Exam2V1._0.Controllers
{
    public class ProductController : Controller
    {
        private readonly ProductContext context;
        public ProductController(ProductContext ctx)
        {
            context = ctx;

        }

        public IActionResult Index()
        {
            var products = context.Products.OrderBy(p => p.ProductId).ToList();
            return View(products);
        }

        public IActionResult Product()
        {
            return View();
        }
    }
}
