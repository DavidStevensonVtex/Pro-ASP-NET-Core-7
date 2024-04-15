//using Microsoft.AspNetCore.Mvc;
//using LanguageFeatures.Models;

namespace LanguageFeatures.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            Product?[] products = Product.GetProducts();
            string? val = products[0]?.Name;
            val = val ?? "No Value";
            return View(new string[] { val });
        }
    }
}
