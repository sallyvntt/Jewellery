using Microsoft.AspNetCore.Mvc;

namespace EP_Jewellery.Areas.Admin.Controllers
{
    public class AdminController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }
    }
}
