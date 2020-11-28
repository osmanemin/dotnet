using System.Collections.Generic;
using dotnet_web.Models;
using dotnet_web.ViewModels;
using Microsoft.AspNetCore.Mvc;
namespace dotnet_web.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index(){

            var product = new Product{Name = "Iphone X", Price = 12000, Description = "Yanarlı Dönerli"};
            
            // ViewData["Product"] = product;
            // ViewData["Category"] = "Telefonlar";

            ViewBag.Category = "Telefonlar";
            // ViewBag.Product = product;

            return View(product);
        }
        public IActionResult List(){

            var products = new List<Product>(){
                new Product{Name = "Iphone X", Price = 12000, Description = "Yanarlı Dönerli"},
                new Product{Name = "Iphone 8", Price = 6000, Description = "Güzel Telefon"}
            };

            var category = new Category{
                Name = "Telefonlar",
                Description = "Telefon Kategorisi"
            };
            
            var productViewModel = new ProductViewModel{
                Category = category,
                Products = products
            };

            return View(productViewModel);
        }
        public IActionResult Details(int id){
            Product product = new Product();
            product.Name = "realm 6";
            product.Price = 2499;
            product.Description = "İyi Telefon";
            return View(product);
        }
    }
}