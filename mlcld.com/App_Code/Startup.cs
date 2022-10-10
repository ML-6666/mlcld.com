using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(mlcld.com.Startup))]
namespace mlcld.com
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
