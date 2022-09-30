using bookstore.Business.Abstract;
using bookstore.Entities.Concrete;
using bookstore.Entities.Dtos;
using FluentValidation;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace bookstore.UI.Controllers
{
    public class AccountController : Controller
    {
        private IAuthenticationService _authenticationService;
        private IAppUserService _appUserService;
        private UserManager<AppIdentityUser> _userManager;
        private SignInManager<AppIdentityUser> _signInManager;
        private IValidator<RegisterDto> _userValidator;
        public AccountController(IAuthenticationService authenticationService, IAppUserService appUserService, UserManager<AppIdentityUser> userManager, SignInManager<AppIdentityUser> signInManager, IValidator<RegisterDto> userValidator)
        {
            _authenticationService = authenticationService;
            _appUserService = appUserService;
            _userManager = userManager;
            _signInManager = signInManager;
            _userValidator = userValidator;
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
                var user = await _userManager.FindByEmailAsync(model.Email);
                if (user != null)
                {
                    var result = await _signInManager.PasswordSignInAsync(user, model.Password, false, false);
                    if (result.Succeeded)
                    {
                        return RedirectToAction("Index", "Home");
                    }
                }
            }
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Register(RegisterDto model)
        {
            var result = _userValidator.Validate(model);
            if (result.IsValid)
            {
                var user = new AppIdentityUser()
                {

                    UserName = model.UserName,
                    Email = model.Email

                };
                user.Id = Guid.NewGuid().ToString();
                var result2 = await _userManager.CreateAsync(user, model.Password);
                if (result2.Succeeded)
                {
                    await _signInManager.SignInAsync(user, false);
                    return RedirectToAction("Index", "Home");
                }
            }
            return View();
        }


        public async Task<IActionResult> Logout()
        {
            await _authenticationService.Logout();
            return RedirectToAction("Login");
        }
    }
}


