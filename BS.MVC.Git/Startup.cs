using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BS.MVC.Git.Startup))]
namespace BS.MVC.Git
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
