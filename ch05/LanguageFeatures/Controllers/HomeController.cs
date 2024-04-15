//using Microsoft.AspNetCore.Mvc;
//using LanguageFeatures.Models;

namespace LanguageFeatures.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            string [] names = new string[3];
            names[0] = "Bob";
            names[1] = "Joe";
            names[2] = "Alice";
            Product?[] products = Product.GetProducts();
            return View("Index", names);
        }
    }
}
