using Microsoft.AspNetCore.Hosting;

[assembly: HostingStartup(typeof(AutoWorld.Web.Areas.Identity.IdentityHostingStartup))]

namespace AutoWorld.Web.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => { });
        }
    }
}
