using EP_Jewellery.Db;
using Microsoft.AspNetCore.Mvc;

namespace EP_Jewellery.Areas.Admin.Controllers
{
    public class AdminController : Controller
    {
        private readonly DatabaseContext db;
        public AdminController(DatabaseContext db) { this.db = db; }

        [Area("Admin")]

        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index", "Home");
        }
        
    }
}
