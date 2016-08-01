using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SalaDeEnsaio.Startup))]
namespace SalaDeEnsaio
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
