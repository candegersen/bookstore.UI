using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using bookstore.Business.Abstract;
using AutoMapper;

namespace bookstore.UI.Controllers
{
    public class ProductController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IProductService _productService;
        private readonly IAuthenticationService _authenticationService;
        private readonly IOrderDetailsService _orderDetailsService;
        private readonly IOrderService _orderService;
        private readonly ICategoryService _categoryService;

        public ProductController(IProductService productService, IAuthenticationService authenticationService, IOrderDetailsService orderDetailsService, IOrderService orderService, ICategoryService categoryService, IMapper mapper)
        {
            _productService = productService;
            _authenticationService = authenticationService;
            _orderDetailsService = orderDetailsService;
            _orderService = orderService;
            _categoryService = categoryService;
            _mapper = mapper;
        }


        public async Task<IActionResult> Index()
        {
            var productList = await _productService.GetProductList();
            return View(productList);
        }

        [HttpGet]
        public async Task<IActionResult> Index(string sort)
        {
            var productList = await _productService.GetProductList();
            var maxProduct = await _productService.MaxPriceProduct();
            var minProduct = await _productService.MinPriceProduct();
            switch (sort)
            {
                case "Artan fiyat": return View(maxProduct);
                case "Azalan fiyat": return View(minProduct);
                default: return View(productList);

            }

        }
    }
}
