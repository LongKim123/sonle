using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(buoi4_lab4.Startup))]
namespace buoi4_lab4
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
