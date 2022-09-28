using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bookstore.Entities.Dtos
{
    public class ProductDto
    {
        public int ProductId { get; set; }

        public string Title  { get; set; }
        public string Author { get; set; }
        public string CategoryName { get; set; }
        public string ShipperName { get; set; }
        public string Description { get; set; }
        public bool State { get; set; }
        public decimal Price { get; set; }
    }
}
