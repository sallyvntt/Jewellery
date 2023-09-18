using EP_Jewellery.Db;
using Microsoft.AspNetCore.Mvc;

namespace EP_Jewellery.Areas.Admin.Controllers
{
    public class AccountController : Controller
    {
        private readonly DatabaseContext db;
        public AccountController(DatabaseContext db) { this.db = db; }
        public ActionResult Account()
        {
            var model = db.User.ToList();
            return View(model);

        }
    }
}
