using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(clickMeetingStandalone.Startup))]
namespace clickMeetingStandalone
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
