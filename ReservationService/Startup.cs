using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ReservationService.Startup))]
namespace ReservationService
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
