using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GitSampleWebApp.Startup))]
namespace GitSampleWebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
