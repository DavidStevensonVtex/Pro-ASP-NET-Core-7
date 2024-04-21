using Microsoft.AspNetCore.Mvc;

namespace SportsStore.Controllers
{
    public class OrderController : Controller
    {
        public IActionResult Checkout() => View(new Order());
    }
}
