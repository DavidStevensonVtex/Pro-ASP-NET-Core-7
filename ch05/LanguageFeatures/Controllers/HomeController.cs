//using Microsoft.AspNetCore.Mvc;
//using LanguageFeatures.Models;

namespace LanguageFeatures.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            Product?[] products = Product.GetProducts();
            Product? p = products[0];
            string val = p != null ? p.Name : "No value";
            return View(new string[] { val });
        }
    }
}
