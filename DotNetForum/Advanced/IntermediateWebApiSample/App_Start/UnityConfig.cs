using System.Web.Http;
using IntermediateWebApiSample.Persistence.Contexts;
using Microsoft.Practices.Unity;
using Unity.WebApi;

namespace IntermediateWebApiSample
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
            var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();

            container.RegisterType<JobsContext, JobsContext>(); //No interface?!?! WTF?!!?

            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}