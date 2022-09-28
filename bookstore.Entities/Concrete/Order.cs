using bookstore.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bookstore.Entities.Concrete
{
    public class Order : IEntity
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime ShipDate { get; set; }
        public bool IsShipped { get; set; } = false;
        public bool IsAllowed { get; set; } = false;
        public virtual ICollection<OrderDetails> OrderDetails { get; set; }

        public int CustomerId { get; set; }
        public AppIdentityUser Customer { get; set; }

        //public int ShipperId { get; set; }
        public Shipper Shipper { get; set; }

        public int PaymentId { get; set; }
        public Payment Payment { get; set; }

        public int AddressId { get; set; }
        public Address Address { get; set; }

    }
}
