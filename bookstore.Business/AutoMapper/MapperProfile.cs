using AutoMapper;
using bookstore.DataAccess.Concrete.Configs;
using bookstore.Entities.Concrete;
using bookstore.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bookstore.Business.AutoMapper
{
    public class MapperProfile : Profile
    {
        //adding dto in entites layer for automapping.
        public MapperProfile()
        {
            CreateMap<Order, OrderDto>().ReverseMap();
            CreateMap<Product, ProductDto>().ReverseMap();
            CreateMap<Shipper, ShipperDto>().ReverseMap();
            CreateMap<Payment, PaymentDto>().ReverseMap();
            CreateMap<Category, CategoryDto>().ReverseMap();
        }
    }
}
