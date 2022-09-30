using bookstore.Business.Abstract;
using bookstore.Business.ValidationRules.FluentValidation;
using bookstore.DataAccess.Abstract;
using bookstore.Entities.Concrete;
using bookstore.Entities.Dtos;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace bookstore.Business.Concrete
{
    public class AppUserManager : IAppUserService
    {
        private readonly IAppIdentityUserDal _userDal;

        AppIdentityValidator validationRules = new AppIdentityValidator();

        public ValidationResult Validation(RegisterDto appUser)
        {
            return validationRules.Validate(appUser);
        }

        public async Task<IList<AppIdentityUser>> GetAllCustomers()
        {
           return await _userDal.GetUsersAsync();
        }

        public async Task<IList<AppIdentityUser>> GetUserListByName(string userName)
        {
            return await GetAllCustomers();
        }

        public Task UserAdd(UserDto userDto)
        {
            throw new NotImplementedException();
        }

        public Task UserRemove(UserDto userDto)
        {
            throw new NotImplementedException();
        }

        public AppUserManager(IAppIdentityUserDal userDal)
        {
            _userDal = userDal;
        }

    }
}
