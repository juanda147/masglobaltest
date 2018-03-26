using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using Autofac;
using Autofac.Integration.Mvc;
using Autofac.Integration.WebApi;
using HandsOn.Business;
using HandsOn.DataAccess.MasGlobalAPI;

namespace HandsOn.UI
{
    public class IoCInitializer
    {
        public static void ConfigureContainer()
        {
            var builder = new ContainerBuilder();
            
            builder.RegisterControllers(Assembly.GetExecutingAssembly());
            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());

            builder.RegisterType<BusinessService>().As<IBusinessService>();
            builder.RegisterType<MasGlobalAPI>().As<IMasGlobalAPI>();

            var container = builder.Build();


            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}