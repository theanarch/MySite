using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyCV.Startup))]
namespace MyCV
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
