using bookstore.Entities.Concrete;
using bookstore.Entities.Dtos;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bookstore.Business.Abstract
{
    public interface IAuthenticationService
    {
        Task<SignInResult> Login(LoginDto model);
        Task<IdentityResult> Register(RegisterDto model);
        Task<IdentityResult> AddRoleToUser(ApplicationIdentity user, string roleName);
        Task<IdentityResult> RemoveRoleFromUser(ApplicationIdentity user, string roleName);
        AppIdentityUser GetUser(string userName);
        AppIdentityUser GetUserByEmail(string email);
        Task Logout();
    }
}
