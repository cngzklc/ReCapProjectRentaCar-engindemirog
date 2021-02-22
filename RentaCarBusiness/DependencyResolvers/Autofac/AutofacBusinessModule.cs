using Autofac;
using Autofac.Extras.DynamicProxy;
using Castle.DynamicProxy;
using Core.Utilities.Interceptors;
using RentaCarBusiness.Abstract;
using RentaCarBusiness.Concrete;
using RentaCarDataAccess.Abstract;
using RentaCarDataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Text;

namespace RentaCarBusiness.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule : Module
    {
        //Burada yapılan işlem; WepAPI/Startup/ConfigureServices(IServiceCollection services) metodu içerisinde oluşturulan service'lerin yerinedir.
        //ConfigureServices veya buradaki(Load) tanımlamalar, ProductManager vb instance'ların her kullanıcı tarafından new'lenmesini engelleyerek performans artışı sağlıyor.
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<BrandManager>().As<IBrandService>().SingleInstance(); //Biri senden IBrandService isterse, son onun yerine BrandManager new'le ver demek.
            builder.RegisterType<EfBrandDal>().As<IBrandDal>().SingleInstance();
            builder.RegisterType<CarManager>().As<ICarService>().SingleInstance();
            builder.RegisterType<EfCarDal>().As<ICarDal>().SingleInstance();
            builder.RegisterType<ColorManager>().As<IColorService>().SingleInstance();
            builder.RegisterType<EfColorDal>().As<IColorDal>().SingleInstance();
            builder.RegisterType<CustomerManager>().As<ICustomerService>().SingleInstance();
            builder.RegisterType<EfCustomerDal>().As<ICustomerDal>().SingleInstance();
            builder.RegisterType<RentalManager>().As<IRentalService>().SingleInstance();
            builder.RegisterType<EfRentalDal>().As<IRentalDal>().SingleInstance();
            builder.RegisterType<UserManager>().As<IUserService>().SingleInstance();
            builder.RegisterType<EfUserDal>().As<IUserDal>().SingleInstance();

            var assembly = System.Reflection.Assembly.GetExecutingAssembly();
            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
                .EnableInterfaceInterceptors(new ProxyGenerationOptions()
                {
                    Selector = new AspectInterceptorSelector()
                }).SingleInstance();
        }
    }
}
