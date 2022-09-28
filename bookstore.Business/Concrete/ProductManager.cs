using AutoMapper;
using bookstore.Business.Abstract;
using bookstore.Business.ValidationRules.FluentValidation;
using bookstore.Core.DataAccess;
using bookstore.DataAccess.Abstract;
using bookstore.Entities.Concrete;
using bookstore.Entities.Dtos;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace bookstore.Business.Concrete
{
    public class ProductManager : IProductService
    {
        private readonly IProductDal _productDal;
        private readonly IMapper _mapper;

        ProductValidator validationRules = new ProductValidator();
        public ProductManager(IProductDal productDal, IMapper mapper)
        {
            _productDal = productDal;
            _mapper = mapper;
        }
        public ValidationResult Validator(Product product)
        {
            return validationRules.Validate(product);
        }

        public async Task Add(Product product)
        {
            await _productDal.Add(product);
        }

        public async Task Update(Product product)
        {
            var result = Validator(product);
            if (result.IsValid)
            {
                await _productDal.Update(product);
            }
        }

        public async Task Delete(Product product)
        {
           await _productDal.Delete(product);
        }

        public async Task<IList<Product>> GetProductList()
        {
            return await _productDal.ProductList();
        }

        public async Task<IList<Product>> ProductWithCategory()
        {
            return await _productDal.GetProductsByCategory();
        }

        public async Task<IList<Product>> MaxPriceProduct()
        {
            return (await _productDal.ProductList()).OrderByDescending(x => x.Price).ToList();
        }

        public async Task<IList<Product>> MinPriceProduct()
        {
            return (await _productDal.ProductList()).OrderBy(x => x.Price).ToList();
        }

        public async Task<Product> GetProduct(Expression<Func<Product, bool>> filter = null)
        {
            return await _productDal.GetProduct(filter);
        }

        public async Task<Product> GetProductById(int id)
        {
            return await _productDal.GetProduct(x => x.Id == id);
        }
    }
}


//cart icine quantity eklendi migration yapıldı, tablo ici doldurulup tekrar viewdata denenecek. 