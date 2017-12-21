﻿using System.Web.Mvc;

namespace FGA.Congressus2.Api.Areas.Eventos
{
    public class EventosAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Eventos";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Eventos_default",
                "Eventos/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}