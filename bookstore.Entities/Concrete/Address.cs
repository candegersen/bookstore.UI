using bookstore.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bookstore.Entities.Concrete
{
    public class Address : IEntity
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string AdressSpace { get; set; }
        public string City { get; set; }
        public string Neighbourhood { get; set; }
        public string PostalCode { get; set; }

        public int AppIdentityUserId { get; set; }
        public AppIdentityUser AppIdentityUser { get; set; }

        public List<Order> Orders { get; set; }


    }
}
