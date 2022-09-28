using bookstore.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bookstore.Entities.Dtos
{
    public class PaymentDto
    {
        public int PaymentId { get; set; }
        public string PaymentType { get; set; }
        public List<Order> Orders { get; set; }
    }
}
