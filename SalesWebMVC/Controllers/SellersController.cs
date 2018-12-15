using Microsoft.AspNetCore.Mvc;
using SalesWebMVC.Models;
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

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost] //Requisição HTTP
        [ValidateAntiForgeryToken] // Validação de Segurança para ninguem aproveitar o token
        public IActionResult Create(Seller seller)
        {
            _sellerSerice.Insert(seller);
            return RedirectToAction(nameof(Index));
        }

    }
}