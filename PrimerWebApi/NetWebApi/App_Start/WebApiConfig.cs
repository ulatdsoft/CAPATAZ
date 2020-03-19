using NetWebApi.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.Serialization;
using System.Web.Http;
using System.Web.Mvc;

namespace NetWebApi
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional });

            //// Formateo del JSON copiado de CAPATAZ
            config.Formatters
                  .JsonFormatter
                  .SerializerSettings
                  .ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
            config.Formatters
                  .JsonFormatter
                  .SerializerSettings
                  .PreserveReferencesHandling = PreserveReferencesHandling.None;
            config.Formatters
                  .JsonFormatter
                  .SerializerSettings
                  .NullValueHandling = NullValueHandling.Ignore;
            //config.Formatters
            //      .JsonFormatter
            //      .SerializerSettings
            //      .Converters
            //      .Add(new Newtonsoft.Json.Converters.StringEnumConverter()); // Serializa Name de la Enum en lugar del Valor numérico

            //// Formateo del JSON  GOOGLEADO
            //config.Formatters
            //      .JsonFormatter
            //      .SerializerSettings
            //      .ReferenceLoopHandling = ReferenceLoopHandling.Serialize;
            //config.Formatters
            //      .JsonFormatter
            //      .SerializerSettings
            //      .PreserveReferencesHandling = PreserveReferencesHandling.All; 

            // Para que devuelva JSON por defecto
            config.Formatters.JsonFormatter.SupportedMediaTypes
                  .Add(new MediaTypeHeaderValue("text/html"));

        }
    }
}
