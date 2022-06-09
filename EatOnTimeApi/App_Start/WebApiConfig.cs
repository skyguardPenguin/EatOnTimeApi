using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using EatOnTimeApi.App_Start;
using System.Web.Http.Cors;
namespace EatOnTimeApi
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Configuración y servicios de API web

            // Rutas de API web
            var cors = new EnableCorsAttribute("*", "*", "*");
            config.EnableCors(cors);
            
            config.MapHttpAttributeRoutes();
            
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
