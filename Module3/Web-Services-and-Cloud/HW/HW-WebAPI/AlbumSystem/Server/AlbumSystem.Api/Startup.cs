using Microsoft.Owin;

[assembly: OwinStartup(typeof(AlbumSystem.Api.Startup))]

namespace AlbumSystem.Api
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
