using bookstore.Core.Entities;
using bookstore.Entities.Abstract;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bookstore.Entities.Concrete
{
    public class AppIdentityUser : IdentityUser<string>, IEntity
    {
        //public string Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public List<Address> Addresses { get; set; }
        public List<Order> Orders { get; set; }
    }
}
