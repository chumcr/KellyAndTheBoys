using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_484_Project.Startup))]
namespace _484_Project
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
