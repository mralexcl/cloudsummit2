using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CloudApplication2.Startup))]
namespace CloudApplication2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
