using Microsoft.AspNetCore.Mvc;

namespace EP_Jewellery.Areas.Admin.Controllers
{
    public class AdminController : Controller
    {
        [Area("Admin")]

        public IActionResult Index()
        {
            return View();
        }
    }
}
