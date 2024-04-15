namespace LanguageFeatures.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            object[] data = new object[] { 275M, 29.95M, "apple", "orange", 100, 10 };
            decimal total = 0;
            foreach ( object dt in data)
            {
                if ( dt is decimal d) 
                {
                    total += d;
                }
            }
            return View("Index", new string[] { $"Total: {total:C2}" });
        }
    }
}
