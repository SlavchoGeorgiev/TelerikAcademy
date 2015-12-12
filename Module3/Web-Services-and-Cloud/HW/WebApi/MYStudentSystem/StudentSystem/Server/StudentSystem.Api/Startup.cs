using Microsoft.Owin;

[assembly: OwinStartup(typeof(StudentSystem.Api.Startup))]

namespace StudentSystem.Api
{
    using Owin;


    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
