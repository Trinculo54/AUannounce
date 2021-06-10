using System.Threading.Tasks;
using Impostor.Api.Games.Managers;
using Impostor.Api.Innersloth;
using Impostor.Api.Plugins;
using Microsoft.Extensions.Logging;

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

        public AUannounce(ILogger<AUannounce> logger, IGameManager gameManager)
        {
            _logger = logger;
            _gameManager = gameManager;
        }

        public override ValueTask EnableAsync()
        {
            _logger.LogInformation("AUannounce is being enabled.");
            return new ValueTask();
        }

        public override ValueTask DisableAsync()
        {
            _logger.LogInformation("AUannounce is being disabled.");
            return default;
        }
    }
}
