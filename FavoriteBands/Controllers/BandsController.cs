using FavoriteBands.Models;
using Microsoft.AspNetCore.Mvc;

namespace FavoriteBands.Controllers
{
    public class BandsController : Controller
    {

        DataService service = DataService.GetInstance();

        [HttpGet("")]
        public IActionResult Index()
        {
            var model = service.GetAllBands();
            return View(model);
        }

        [HttpGet("bands/details/{bandID}")]
        public IActionResult Details(int bandID)
        {
            var model = service.GetBand(bandID);
            return View(model);
        }
    }
}
