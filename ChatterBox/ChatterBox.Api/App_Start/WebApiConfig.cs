using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Routing;
using Microsoft.Web.Http.Routing;
using NLog;

namespace ChatterBox.Api
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            //Ведение лога
            Logger Log = LogManager.GetCurrentClassLogger();

            Log.Debug("Настройка конфигурации и служб Web API");
            // Конфигурация и службы веб-API
            var constraintResolver = new DefaultInlineConstraintResolver()
            {
                ConstraintMap =
                {
                    ["apiVersion"] = typeof( ApiVersionRouteConstraint )
                }
            };

            Log.Debug("Настройка маршрутов Web API");
            // Маршруты веб-API
            config.MapHttpAttributeRoutes(constraintResolver);
            config.AddApiVersioning();

            Log.Debug("Настройка обработчика запросов Web API");
            //Обработчик запросов к Web API
            config.MessageHandlers.Add(new ControllerHandler());

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
