using Microsoft.AspNetCore.Mvc;
using ShopHub.entities;
using ShopHub.Models;
using System.Net.Sockets;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using ShopHub.Models;

namespace Medicover_Hospitals
{
    public class AccountController : Controller
    {
        public IActionResult Login()
        {
            return View(new LoginModel());
        }
        [HttpPost]
        public IActionResult SubmitLogin(LoginModel loginmodel)
        {
            var dbcontext = new ShopHubDBContext();
            Login userObj = dbcontext.Logins.FirstOrDefault(p => p.Username == loginmodel.Username && p.Password == loginmodel.Password);
            if (userObj == null)
            {
                ModelState.AddModelError("", "Entered username or password is incorrect.");
                return View("Login", loginmodel);
            }
            else
            {
                return RedirectToAction("PList", "Product");
            }
        }

        public IActionResult RegisterForm()
        {
            var model = new RegisterModel();
            return View(model);
        }
        [HttpPost]
        public IActionResult SaveUser(RegisterModel registerModel)
        {
            var dbcontext = new ShopHubDBContext();
            Login NewLogin = new Login();
            NewLogin.Username = registerModel.Username;
            NewLogin.Password = registerModel.Password;
            NewLogin.MobileNo = registerModel.MobileNo;

            dbcontext.Logins.Add(NewLogin);
            dbcontext.SaveChanges();

            return RedirectToAction("Login");
        }
    }
}
