using Exam2V1._0.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Diagnostics;
using Exam2V1._0.Migrations;

namespace Exam2V1._0.Controllers
{
    public class ProductController : Controller
    {
        private readonly ProductContext context;
        public ProductController(ProductContext ctx)
        {
            context = ctx;

        }

        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.Action = "Add";
            return View("Edit", new Product());
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Action = "Confirm";
            var product = context.Products.Find(id);
            return View(product);
        }
        [HttpPost]
        public IActionResult Edit(Product product)
        {
            if (ModelState.IsValid)
            {
                if (product.ProductId == 0)
                {
                    context.Products.Add(product);
                }
                else
                {
                    context.Products.Update(product);
                }
                    context.SaveChanges();
                    return RedirectToAction("Index", "Home");
            }
            else
            {
                if (product.ProductId == 0)
                {
                    ViewBag.Name = "Add";
                }
                else
                {
                    ViewBag.Name = "Edit";
                }
                return View(product);
            }

        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var product = context.Products.Find(id);
            return View(product);
        }
        [HttpPost]
        public IActionResult Delete(Product product)
        {
            context.Products.Remove(product);
            context.SaveChanges();
            return RedirectToAction("Index", "Home");
        }
    }
}
