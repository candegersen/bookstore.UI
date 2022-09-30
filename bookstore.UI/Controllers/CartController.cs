using bookstore.DataAccess.Concrete;
using bookstore.Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;

namespace bookstore.UI.Controllers
{
    public class CartController : Controller
    {
        private readonly MyDbContext _context;

        public CartController(MyDbContext context)
        {
            _context = context;
        }

        public IActionResult AddCart(int id)
        {
            if (HttpContext.Session.GetString("ssCart") == null)
            {
                List<int> list = new List<int>();
                list.Add(id);
                HttpContext.Session.SetString("ssCart", JsonConvert.SerializeObject(list));
                return RedirectToAction("Index", "Product");
            }
            else
            {
                List<int> list = JsonConvert.DeserializeObject<List<int>>(HttpContext.Session.GetString("ssCart"));
                list.Add(id);
                HttpContext.Session.SetString("ssCart", JsonConvert.SerializeObject(list));
            }
            return RedirectToAction("Index", "Product");
        }



        public IActionResult Index()
        {

            List<Product> list = new List<Product>();
            List<int> list1 = JsonConvert.DeserializeObject<List<int>>(HttpContext.Session.GetString("ssCart"));
            foreach (var item in list1)
            {
                Product p = _context.Product.Where(x => x.Id == item).FirstOrDefault();
                list.Add(p);
            }
            return View(list);
        }


        public IActionResult Delete(int id)
        {
            List<int> list = JsonConvert.DeserializeObject<List<int>>(HttpContext.Session.GetString("ssCart"));
            list.Remove(id);
            HttpContext.Session.SetString("ssCart", JsonConvert.SerializeObject(list));
            return View("Index", "Cart");
        }


        //checkout icin content ekle
        
        public IActionResult Checkout()
        {
            var list1 = _context.Product.Where(x => x.Id == 1).FirstOrDefault();
            List<int> list = JsonConvert.DeserializeObject<List<int>>(HttpContext.Session.GetString("ssCart"));
            foreach (var item in list)
            {
                Product p = _context.Product.Where(x => x.Id == item).FirstOrDefault();
                p.Quantity -= 1;
                _context.SaveChanges();
            }
                return View();
        }
    }
}

