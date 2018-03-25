using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HandsOn.Startup))]
namespace HandsOn
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
