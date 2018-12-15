using Microsoft.AspNetCore.Mvc;
using SalesWebMVC.Services;

namespace SalesWebMVC.Controllers
{
    public class SellersController : Controller
    {
        private readonly SellerService _sellerSerice;

        public SellersController(SellerService sellerSerice)
        {
            _sellerSerice = sellerSerice;
        }


        public IActionResult Index()
        {
            var list = _sellerSerice.FindAll();
            return View(list);
        }
    }
}