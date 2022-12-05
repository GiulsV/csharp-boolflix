using Microsoft.AspNetCore.Mvc;

namespace csharp_boolflix.Controllers
{
    public class TvSeriesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
