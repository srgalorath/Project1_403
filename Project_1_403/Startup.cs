using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Project_1_403.Startup))]
namespace Project_1_403
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
