using System.Threading.Tasks;
using Impostor.Api.Games.Managers;
using Impostor.Api.Innersloth;
using Impostor.Api.Plugins;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Configuration;

namespace Impostor.Plugins.AUannounce
{
    [ImpostorPlugin(
    package: "gg.impostor.AUannounce",
    name: "AUannounce",
    author: "Trinculo54",
    version: "1.0.0")]
    public class AUannounce : PluginBase
    {
        private readonly ILogger<AUannounce> _logger;
        private readonly IGameManager _gameManager;

        internal static AUannounceSettings settings = new AUannounceSettings();

        public AUannounce(ILogger<AUannounce> logger, IGameManager gameManager)
        {
            _logger = logger;
            _gameManager = gameManager;

            new ConfigurationBuilder()
            .AddJsonFile("config.json", optional: false, reloadOnChange: false)
            .Build()
            .Bind("AUannounce", settings);
        }

        public override ValueTask EnableAsync()
        {
            _logger.LogInformation("AUannounce is being enabled.");
            _logger.LogInformation($"the announcement is " + settings.Announcement);
            return new ValueTask();
        }

        public override ValueTask DisableAsync()
        {
            _logger.LogInformation("AUannounce is being disabled.");
            return default;
        }
    }
}