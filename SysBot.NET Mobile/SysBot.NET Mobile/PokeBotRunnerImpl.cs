using System;
using PKHeX.Core;
using SysBot.Pokemon.Discord;
using SysBot.Pokemon.Twitch;
using System.Threading;
using System.Threading.Tasks;
using SysBot.Pokemon;

namespace SysBot.NET_Mobile
{
    public class PokeBotRunnerImpl : PokeBotRunner
    {
        public PokeBotRunnerImpl(PokeTradeHub<PK8> hub) : base(hub) { }
        public PokeBotRunnerImpl(PokeTradeHubConfig config) : base(config) { }
#nullable enable
        private static TwitchBot? Twitch;
#nullable disable
        protected override void AddIntegrations()
        {
            if (!string.IsNullOrWhiteSpace(Hub.Config.Discord.Token))
                AddDiscordBot(Hub.Config.Discord.Token);

            if (!string.IsNullOrWhiteSpace(Hub.Config.Twitch.Token))
                AddTwitchBot(Hub.Config.Twitch);
        }

        private void AddTwitchBot(TwitchSettings config)
        {
            if (Twitch != null)
                return; // already created

            if (string.IsNullOrWhiteSpace(config.Channel))
                return;
            if (string.IsNullOrWhiteSpace(config.Username))
                return;
            if (string.IsNullOrWhiteSpace(config.Token))
                return;

            Twitch = new TwitchBot(Hub.Config.Twitch, Hub);
            if (Hub.Config.Twitch.DistributionCountDown)
                Hub.BotSync.BarrierReleasingActions.Add(() => Twitch.StartingDistribution(config.MessageStart));
        }

        private void AddDiscordBot(string apiToken)
        {
            SysCordInstance.Runner = this;
            var bot = new SysCord(Hub);
            Task.Run(() => bot.MainAsync(apiToken, CancellationToken.None));
        }
    }
}
