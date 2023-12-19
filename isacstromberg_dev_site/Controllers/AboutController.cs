using Microsoft.AspNetCore.Mvc;

namespace isacstromberg_dev_site.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
