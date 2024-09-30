using ExpenseManagement.DataLayer;
using ExpenseManagement.Models;
using Microsoft.AspNetCore.Mvc;

namespace ExpenseManagement.Controllers
{
    public class UserProfileController : Controller
    {
        private readonly DbContextExpMgt _context;

        public UserProfileController(DbContextExpMgt context)
        {
            _context = context; 
        }
        public IActionResult Login(string EmailAddress, string Password)
        {
            ViewBag.LoginStatus = "";
            if (ModelState.IsValid)
            {
                var userCheck = _context.UserProfile.FirstOrDefault
                    (a=>a.EmailAddress == EmailAddress && a.Password == Password);
                if (userCheck == null)
                {
                    ViewBag.LoginStatus = "Invalid Login or User not registered";
                }
                else
                {
                    return RedirectToAction("Index","Home");
                }
            }
            return View();
        }


        public IActionResult Registration(UserProfile userDetails)
        {
          
            if (ModelState.IsValid)
            {
               _context.UserProfile.Add(userDetails);
                _context.SaveChanges();
                return RedirectToAction("Login");
            }
            return View();
        }





        public IActionResult Index()
        {
            return View();
        }
    }
}
