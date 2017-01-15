using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MakingItPretty.Startup))]
namespace MakingItPretty
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
