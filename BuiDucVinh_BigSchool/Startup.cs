using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BuiDucVinh_BigSchool.Startup))]
namespace BuiDucVinh_BigSchool
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
