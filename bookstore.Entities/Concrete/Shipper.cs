using bookstore.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bookstore.Entities.Concrete
{
    public class Shipper : IEntity
    {
        public int Id { get; set; }
        public string ShipperName { get; set; }
        public string Phone { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
        public virtual AppIdentityUser AppIdentityUser { get; set; }
    }
}
