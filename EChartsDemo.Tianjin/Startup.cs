using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EChartsDemo.Tianjin.Startup))]
namespace EChartsDemo.Tianjin
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
            app.UseNancy();
        }
    }
}
