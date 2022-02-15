using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ActionResultDemo.Startup))]
namespace ActionResultDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
