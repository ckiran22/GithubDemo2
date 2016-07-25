using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GithubDemo.Startup))]
namespace GithubDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
