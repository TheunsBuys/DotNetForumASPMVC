using System.Web.Http;
using IntermediateWebApiSample.Attributes;

namespace IntermediateWebApiSample
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                "DefaultApi",
                "api/{controller}/{id}",
                new {id = RouteParameter.Optional}
                );

            config.Filters.Add(new ValidateModelAttribute());
                //The validation attribute can be applied to all web requests.
        }
    }
}