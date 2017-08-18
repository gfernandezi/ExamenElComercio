using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ExamenMetrica.Startup))]
namespace ExamenMetrica
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
