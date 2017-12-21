using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Owin;
using Owin;
using FGA.Congressus2.Api.App_Start;
using Autofac;

[assembly: OwinStartup(typeof(FGA.Congressus2.Api.Startup))]

namespace FGA.Congressus2.Api
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);          
        }
    }
}
