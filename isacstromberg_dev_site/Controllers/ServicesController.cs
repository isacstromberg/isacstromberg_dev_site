using Microsoft.AspNetCore.Mvc;

namespace isacstromberg_dev_site.Controllers
{
    public class ServicesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
