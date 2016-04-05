using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CssMediaQueryTest.Startup))]
namespace CssMediaQueryTest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
