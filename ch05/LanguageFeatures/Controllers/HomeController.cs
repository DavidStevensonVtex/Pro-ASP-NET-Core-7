namespace LanguageFeatures.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var names = new[] { "Kayak", "Lifejacket", "Soccer ball" };
            return View(names);
        }
    }
}
