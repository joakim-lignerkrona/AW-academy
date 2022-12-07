using Microsoft.AspNetCore.Mvc;

namespace ACME.Controllers
{
    public class ProductsController : Controller
    {
        [HttpGet("home"), HttpGet("index.html"), HttpGet("")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
