using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(StockTracker.Startup))]
namespace StockTracker
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
