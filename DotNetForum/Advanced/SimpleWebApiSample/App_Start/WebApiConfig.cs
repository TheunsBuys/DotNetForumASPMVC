using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Serialization;
using SimpleWebApiSample.Attributes;

namespace SimpleWebApiSample
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
                defaults: new { id = RouteParameter.Optional }
            );

            //The response formatting can be applied to all web requests and responses.
            //config.Formatters.JsonFormatter.SerializerSettings.Converters.Add(new StringEnumConverter());
            //config.Formatters.JsonFormatter.SerializerSettings.ContractResolver =
            //    new CamelCasePropertyNamesContractResolver();

            //config.Filters.Add(new ValidateModelAttribute()); 
            //The validation attribute can be applied to all web requests.
        }
    }
}
