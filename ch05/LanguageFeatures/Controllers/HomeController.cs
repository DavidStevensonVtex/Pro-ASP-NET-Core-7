namespace LanguageFeatures.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index() =>
            View(Product.GetProducts().Select(p => p?.Name));
    }
}
