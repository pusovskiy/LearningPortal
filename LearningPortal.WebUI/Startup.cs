using Owin;
using Microsoft.Owin;

[assembly: OwinStartupAttribute(typeof(LearningPortal.WebUI.Startup))]
[assembly: log4net.Config.XmlConfigurator(ConfigFile = "Web.config", Watch = true)]
namespace LearningPortal.WebUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            //ConfigureAuth(app);
        }
    }
}