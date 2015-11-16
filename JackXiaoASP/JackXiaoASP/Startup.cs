using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(JackXiaoASP.Startup))]
namespace JackXiaoASP
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
