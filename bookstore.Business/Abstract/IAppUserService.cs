using bookstore.Entities.Concrete;
using bookstore.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bookstore.Business.Abstract
{
    public interface IAppUserService
    {
        Task<IList<AppIdentityUser>> GetAllCustomers();
        Task<IList<AppIdentityUser>> GetUserListByName(string userName);
        Task UserAdd(UserDto userDto);
        Task UserRemove(UserDto userDto);



    }
}
