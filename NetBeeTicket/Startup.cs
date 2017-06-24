using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NetBeeTicket.Startup))]
namespace NetBeeTicket
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
