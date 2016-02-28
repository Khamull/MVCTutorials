using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TesteCkEditor.Startup))]
namespace TesteCkEditor
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
