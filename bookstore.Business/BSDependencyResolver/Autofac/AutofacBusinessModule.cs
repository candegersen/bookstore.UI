using Autofac;
using bookstore.Business.Abstract;
using bookstore.Business.Concrete;
using bookstore.DataAccess.Abstract;
using bookstore.DataAccess.Concrete;
using bookstore.DataAccess.Concrete.EntityFramework;
using bookstore.Entities.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bookstore.Business.ValidationRules.FluentValidation;
using FluentValidation;
using bookstore.Entities.Dtos;

namespace bookstore.Business.BSDependencyResolver.Autofac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ProductManager>().As<IProductService>();
            builder.RegisterType<CategoryManager>().As<ICategoryService>();
            builder.RegisterType<OrderManager>().As<IOrderService>();
            builder.RegisterType<OrderDetailsManager>().As<IOrderDetailsService>();
            builder.RegisterType<AppUserManager>().As<IAppUserService>();
            builder.RegisterType<AuthenticationManager>().As<IAuthenticationService>();
            builder.RegisterType<ShipperManager>().As<IShipperService>();
            builder.RegisterType<PaymentManager>().As<IPaymentService>();

            builder.RegisterType<ProductDal>().As<IProductDal>();
            builder.RegisterType<CategoryDal>().As<ICategoryDal>();
            builder.RegisterType<OrderDal>().As<IOrderDal>();
            builder.RegisterType<OrderDetailsDal>().As<IOrderDetailsDal>();
            builder.RegisterType<ShipperDal>().As<IShipperDal>();
            builder.RegisterType<AppIdentityUserDal>().As<IAppIdentityUserDal>();

            builder.RegisterType<AppIdentityValidator>().As<IValidator<RegisterDto>>();


           
            base.Load(builder);
           
           
        }
    }
}
