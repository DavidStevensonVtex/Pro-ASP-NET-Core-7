namespace LanguageFeatures.Controllers
{
    public class HomeController : Controller
    {
        public async Task<ViewResult> Index()
        {
            List<string> output = new List<string>();
            await foreach (long? len in MyAsyncMethods.GetPageLengths(
                output,
                "manning.com", "microsoft.com", "amazon.com"))
            {
                output.Add($"Page length: {len:N0}");
            }
            return View(output);
        }
    }
}
