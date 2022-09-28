using bookstore.Business.Abstract;
using bookstore.Entities.Dtos;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace bookstore.UI.Controllers
{
    public class AccountController : Controller
    {
        private IAuthenticationService _authenticationService;
        public AccountController(IAuthenticationService authenticationService)
        {
            _authenticationService = authenticationService;
        }

        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(LoginDto model)
        {
            if (ModelState.IsValid)
            {
                var result = await _authenticationService.Login(model);
                if (result.Succeeded)
                {
                    var user = _authenticationService.GetUserByEmail(model.Email);
                    return RedirectToAction("Index", "Home"); //config this.
                }
            }
            ModelState.AddModelError("", "Girilen değerleri kontrol ediniz.");
            return View(model);
        }

        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Register(RegisterDto model)
        {
            var result = await _authenticationService.Register(model);
            if (result.Succeeded)
            {
                //opt error
            }
            return RedirectToAction("Login");
        }
        public async Task<IActionResult> Logout()
        {
            await _authenticationService.Logout();
            return RedirectToAction("Login");
        }
    }
}
