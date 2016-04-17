using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Person.Web.Startup))]
namespace Person.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
