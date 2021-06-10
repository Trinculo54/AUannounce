using Impostor.Api.Events;
using Impostor.Api.Plugins;
using Impostor.Plugins.AUannounce.Handlers;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Impostor.Plugins.AUannounce
{
    public class AUannounceStartup : IPluginStartup
    {
        public void ConfigureHost(IHostBuilder host)
        {
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<IEventListener, AnnouncementsListener>();
        }
    }
}
