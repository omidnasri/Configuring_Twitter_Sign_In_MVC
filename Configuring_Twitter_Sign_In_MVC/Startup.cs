using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Configuring_Twitter_Sign_In_MVC.Startup))]
namespace Configuring_Twitter_Sign_In_MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
