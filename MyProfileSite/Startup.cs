using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyProfileSite.Startup))]
namespace MyProfileSite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
