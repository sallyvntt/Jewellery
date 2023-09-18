using EP_Jewellery.Models;
using EP_Jewellery.Repository.Home;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;
using System.Diagnostics;

namespace EP_Jewellery.Controllers
{
    public class HomeController : Controller
    {
        
        private readonly IHome service;
        private readonly DatabaseContext db;

        public HomeController(IHome service, DatabaseContext db)
        {
            this.service = service;
            this.db = db;
        }
        

        public IActionResult Index()
        {
            string username = HttpContext.Session.GetString("username")!;
            var acc = db.Admin.SingleOrDefault(a => a.username.Equals(username));
            if (acc != null)
            {

                ViewBag.Admin = "string";
                return View("Index");
            }
            else
            {
                return View("Index");

            }
        }
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(string username, string password)
        {
            var action = service.Login(username, password);
            if (action.Result == true)
            {

                HttpContext.Session.SetString("username", username);
                return RedirectToAction("Index");

            }
            else
            {

                ViewBag.message = "Login not successful , check again !";

                return View();
            }
        }
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Register(User newUser)
        {
            if (ModelState.IsValid)
            {
                var acc = db.User.FirstOrDefault(a => a.userId == newUser.userId);
                if (acc == null)
                {
                    newUser.password = newUser.password;
                    newUser.emailID = newUser.emailID;


                    db.User.Add(newUser);
                    db.SaveChanges();
                    return View("Login");
                }
                else
                {
                    ViewBag.error = "Account already exits!";
                    //return View();
                }
            }
            return View("Login");
        }
        [HttpGet]
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Login");
        }
        public IActionResult Detail(string id)
        {
            id = HttpContext.Session.GetString("username")!;
            var acc = db.User.SingleOrDefault(a => a.userId!.Equals(id));
            if (acc != null)
            {
                return View(acc);
            }
            else
            {
                return RedirectToAction("Login");
            }
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}