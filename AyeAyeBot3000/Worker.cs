using AyeAyeBot3000.Giphy;
using DSharpPlus;
using DSharpPlus.Entities;
using DSharpPlus.EventArgs;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading;
using System.Threading.Tasks;

namespace AyeAyeBot3000
{
    public class Worker : BackgroundService
    {
        private ILogger<Worker> logger;
        private IConfiguration configuration;
        private DiscordClient discordClient;
        private GiphyService giphy;

        private string discordBotToken;

        public Worker(ILogger<Worker> logger, IConfiguration configuration, GiphyService giphy)
        {
            this.logger = logger;
            this.configuration = configuration;
            this.giphy = giphy;


            discordBotToken = configuration["DiscordBotToken"];

            
        }

        public override async Task StartAsync(CancellationToken cancellationToken)
        {
            logger.LogInformation("Starting discord bot");

           
            discordClient = new DiscordClient(new DiscordConfiguration()
            {
                Token = discordBotToken,
                TokenType = TokenType.Bot,
                Intents = DiscordIntents.AllUnprivileged | DiscordIntents.GuildMembers
                
            });

            discordClient.MessageCreated += OnMessageCreated;

            discordClient.VoiceStateUpdated += OnVoiceChannelMemberChange;
            

            await discordClient.ConnectAsync();
        }


        protected override Task ExecuteAsync(CancellationToken stoppingToken) => Task.CompletedTask;

        public override async Task StopAsync(CancellationToken cancellationToken)
        {
            discordClient.MessageCreated -= OnMessageCreated;
            await discordClient.DisconnectAsync();
            discordClient.Dispose();
            logger.LogInformation("Discord bot stopped");
        }

        private async Task OnMessageCreated(DiscordClient client, MessageCreateEventArgs e)
        {
            if (e.Message.Content.StartsWith("ping", StringComparison.OrdinalIgnoreCase))
            {
                logger.LogInformation("pinged, responding with pong!");
                await e.Message.RespondAsync("pong!");
            }

            if (e.Message.Content.Contains("pummel party", StringComparison.OrdinalIgnoreCase))
            {
                logger.LogInformation("pummel party alert, responding with shhhhhhhhhhhhhhhh!");
                await e.Message.RespondAsync("shhhhhhhhhhhhhhhh");
            }
        }

        private async Task OnVoiceChannelMemberChange(DiscordClient client, VoiceStateUpdateEventArgs e)
        {
            
            var server = client.Guilds.SingleOrDefault(x => x.Value == e.Guild).Value;
            var voiceChannel = server.Channels.SingleOrDefault(x => x.Value == e.Channel).Value;

            var generalTextChannel = server.Channels.SingleOrDefault(x => x.Value.Name == "general").Value;


            if(e.After != null && (e.Before == null || e.Before.Channel == null))
            {
                
                var msg = await new DiscordMessageBuilder()
                    .WithContent($"Shits Happening Boyos  \n {await giphy.GetGif("party")}")                    
                    .WithAllowedMentions(new IMention[] { new EveryoneMention() })
                    .SendAsync(generalTextChannel);
            }
          
        }



    }
}
