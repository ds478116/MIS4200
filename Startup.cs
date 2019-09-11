using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Dominic1.Startup))]
namespace Dominic1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
