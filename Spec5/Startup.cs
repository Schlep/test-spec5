using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Spec5.Startup))]
namespace Spec5
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
