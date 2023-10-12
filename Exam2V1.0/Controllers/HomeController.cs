using Exam2V1._0.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Exam2V1._0.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> logger;
        private readonly ProductContext context;
        public HomeController(ILogger<HomeController> log, ProductContext ctx)
        {
            logger = log;
            context = ctx;

        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Product()
        {
            try
            {
                List<Product> products = context.Products.ToList();
                logger.LogInformation($"Number of products fetched: {products.Count}");
                return View(products);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Error fetching products from the database");
                throw; // Rethrow the exception for now, you might want to handle it more gracefully in production
            }
        }
        public IActionResult Edit()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}