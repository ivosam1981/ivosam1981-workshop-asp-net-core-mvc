using Microsoft.AspNetCore.Mvc;

namespace SallesWebMvc.Controllers
{
    public class SellersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
