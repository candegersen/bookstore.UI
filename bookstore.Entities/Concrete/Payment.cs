using bookstore.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bookstore.Entities.Concrete
{
    public class Payment : IEntity
    {
        public int PaymentId { get; set; }
        public string PaymentType { get; set; }
        public List<Order> Orders { get; set; }
    }
}
