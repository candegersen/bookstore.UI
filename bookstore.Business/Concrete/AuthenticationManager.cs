using bookstore.Business.Abstract;
using bookstore.Entities.Concrete;
using bookstore.Entities.Dtos;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bookstore.Business.Concrete
{
    public class AuthenticationManager :IAuthenticationService
    {
        private readonly UserManager<AppIdentityUser> _userManager;
        private readonly RoleManager<AppIdentityRole> _roleManager;
        private readonly SignInManager<AppIdentityUser> _signInManager;

        public AuthenticationManager(UserManager<AppIdentityUser> userManager, RoleManager<AppIdentityRole> roleManager, SignInManager<AppIdentityUser> signInManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _signInManager = signInManager;
        }
        public async Task<SignInResult> Login(LoginDto model)
        {
            var user = await _userManager.FindByEmailAsync(model.Email);

            if (user == null)
            {
                throw new Exception("Couldn't find the user.");
            }

            var result = await
                _signInManager.PasswordSignInAsync(user, model.Password, model.RememberMe, false);
            return result;
        }

        public async Task<IdentityResult> Register(RegisterDto model)
        {
            var user = new AppIdentityUser
            {
                UserName = model.UserName,
                Email = model.Email,
            };
            var result = await _userManager.CreateAsync(user, model.Password);

            if (result.Succeeded)
            {
                //await AddRoleToUser(user, "User");
            }
            return result;
        }

        public async Task Logout()
        {
            await _signInManager.SignOutAsync();
        }

        Task<IdentityResult> IAuthenticationService.AddRoleToUser(ApplicationIdentity user, string roleName)
        {
            throw new NotImplementedException();
        }

        Task<IdentityResult> IAuthenticationService.RemoveRoleFromUser(ApplicationIdentity user, string roleName)
        {
            throw new NotImplementedException();
        }

        public AppIdentityUser GetUser(string userName)
        {
            var user = _userManager.Users.FirstOrDefault(x => x.UserName == userName);
            if (user is null)
            {
                return null;
            }
            return user;
        }

        public AppIdentityUser GetUserByEmail(string email)
        {
            var user = _userManager.Users.SingleOrDefault(x => x.Email == email);
            if (user is null)
            {
                return null;
            }
            return user;
        }
    }
}
