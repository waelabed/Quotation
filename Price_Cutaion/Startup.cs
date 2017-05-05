using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Price_Cutaion.Startup))]
namespace Price_Cutaion
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
