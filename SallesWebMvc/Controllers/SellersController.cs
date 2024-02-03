using Microsoft.AspNetCore.Mvc;
using SallesWebMvc.Services;

namespace SallesWebMvc.Controllers
{
    public class SellersController : Controller
    {
        private readonly SellerService _sellerService;

        public SellersController(SellerService sellerService)
        {
            _sellerService = sellerService;
        }

        public IActionResult Index()
        {
            var list = _sellerService.findAll();

            return View(list);
        }

    }
}
