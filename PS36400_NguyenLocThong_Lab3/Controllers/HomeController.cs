using Microsoft.AspNetCore.Mvc;
using PS36400_NguyenLocThong_Lab3.Models;
using PS36400_NguyenLocThong_Lab3.Repositories;
using System.Diagnostics;

namespace PS36400_NguyenLocThong_Lab3.Controllers
{
    public class HomeController : Controller
    {
        private IProductService _productService;
		public HomeController(IProductService productService)
		{
			_productService = productService;
		}

		public IActionResult Index()
        {
			_productService = new ProductService();
            return View(_productService.GetAllProducts());
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
