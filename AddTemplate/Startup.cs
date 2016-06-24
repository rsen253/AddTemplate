using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AddTemplate.Startup))]
namespace AddTemplate
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
