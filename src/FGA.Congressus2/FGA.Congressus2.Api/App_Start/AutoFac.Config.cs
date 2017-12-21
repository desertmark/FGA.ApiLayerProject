using Autofac;
using Autofac.Integration.WebApi;
using FGA.Congressus2.Data.Context;
using FGA.Congressus2.Data.Repositories;
using FGA.Congressus2.Data.Stores;
using FGA.Congressus2.Negocio.Negocio;
using Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Compilation;
using System.Web.Http;

namespace FGA.Congressus2.Api.App_Start
{
    public class AutoFacConfig
    {
        public static void Configure(HttpConfiguration config)
        {
            //Load the assemblies
            var assemblies = BuildManager.GetReferencedAssemblies().Cast<Assembly>();
            var data = Assembly.GetAssembly(typeof(Congressus2Entities));
            var negocio = Assembly.GetAssembly(typeof(UsuarioNegocio));

            // Create your builder.
            var builder = new ContainerBuilder();

            // Get your HttpConfiguration.
            //var config = GlobalConfiguration.Configuration;

            //Regiter types            
            builder.RegisterType<IdentityContext>().AsSelf();
            builder.RegisterType<Congressus2Entities>().AsSelf();

            builder.RegisterType<UsuarioStore>().AsSelf();
            builder.RegisterType<UsuarioNegocio>().AsSelf();

            builder.RegisterGeneric(typeof(Repository<>)).AsImplementedInterfaces();
            builder.RegisterGeneric(typeof(Negocio<>)).AsImplementedInterfaces();

            builder
                .RegisterAssemblyTypes(data)
                .Where(t => t.Name.EndsWith("Repository")).AsImplementedInterfaces();
            builder
                .RegisterAssemblyTypes(negocio)
                .Where(t => t.Name.EndsWith("Negocio")).AsImplementedInterfaces();

            // Register your Web API controllers.
            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());

            var container =  builder.Build();        
            // Set the dependency resolver to be Autofac.
            config.DependencyResolver = new AutofacWebApiDependencyResolver(container);

            //app.UseAutofacMiddleware(container);
            //app.UseAutofacWebApi(config);
        }
    }
}