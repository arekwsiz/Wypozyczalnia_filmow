using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Wypozyczalnia_filmow.Startup))]
namespace Wypozyczalnia_filmow
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
