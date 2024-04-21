using Microsoft.AspNetCore.Mvc;

namespace SportsStore.Controllers
{
    public class Order : Controller
    {
        public IActionResult Checkout() => View(new Order());
    }
}
