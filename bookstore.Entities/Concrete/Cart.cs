using bookstore.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bookstore.Entities.Concrete
{
    public class Cart : IEntity
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public int Count { get; set; }
        public Product Product { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }
        public DateTime Created { get; set; }
    }
}
