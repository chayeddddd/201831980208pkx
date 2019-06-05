using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_201831980208pkx.Startup))]
namespace _201831980208pkx
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
