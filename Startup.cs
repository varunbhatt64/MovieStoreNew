using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MovieStoreNew.Startup))]
namespace MovieStoreNew
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
