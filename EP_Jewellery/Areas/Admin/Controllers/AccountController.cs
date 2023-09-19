using EP_Jewellery.Db;
using Microsoft.AspNetCore.Mvc;

namespace EP_Jewellery.Areas.Admin.Controllers
{
    public class AccountController : Controller
    {
        private readonly DatabaseContext db;
        public AccountController(DatabaseContext db) { this.db = db; }

        [Area("Admin")]
        public ActionResult Index()
        {
            var model = db.User.ToList();
            return View(model);

        }
    }
}
