using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC_Demo.Startup))]
namespace MVC_Demo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
