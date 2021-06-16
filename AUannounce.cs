using System.Threading.Tasks;
using Impostor.Api.Games.Managers;
using Impostor.Api.Innersloth;
using Impostor.Api.Plugins;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Configuration;

namespace Impostor.Plugins.AUannounce
{
    [ImpostorPlugin("gg.impostor.AUannounce")]
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
            if (settings.Enabled == true)
            {
                _logger.LogInformation("AUannounce is being enabled.");
                string replaceWith = " ";
                string removedBreaks = AUannounce.settings.Announcement.Replace("\r\n", replaceWith).Replace("\n", replaceWith).Replace("\r", replaceWith);
                _logger.LogInformation($"The latest announcement is " + removedBreaks);
                return new ValueTask();
            }
            else
            {
                _logger.LogInformation("AUannounce is off");
                string replaceWith = " ";
                string removedBreaks = AUannounce.settings.Announcement.Replace("\r\n", replaceWith).Replace("\n", replaceWith).Replace("\r", replaceWith);
                _logger.LogInformation($"The last logged announcement is " + removedBreaks);
                return new ValueTask();
            }
        }

        public override ValueTask DisableAsync()
        {
            _logger.LogInformation("AUannounce is being disabled.");
            return default;
        }
    }
}