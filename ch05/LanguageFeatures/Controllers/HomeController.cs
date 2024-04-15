namespace LanguageFeatures.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View(Product.GetProducts().Select(p => p?.Name));
        }
    }
}
