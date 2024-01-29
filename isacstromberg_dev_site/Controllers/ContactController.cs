using Microsoft.AspNetCore.Mvc;

namespace isacstromberg_dev_site.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
