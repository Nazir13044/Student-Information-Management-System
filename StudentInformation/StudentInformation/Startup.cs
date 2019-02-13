using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(StudentInformation.Startup))]
namespace StudentInformation
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
