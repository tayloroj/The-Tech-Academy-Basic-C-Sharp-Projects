using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreTour.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
