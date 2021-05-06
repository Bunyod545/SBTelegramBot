using SB.TelegramBot;
using SB.TelegramBot.AspNetCore;
using SB.TelegramBot.Logics.TelegramBotConfigs;

namespace Microsoft.AspNetCore.Builder
{
    /// <summary>
    /// 
    /// </summary>
    public static class ApplicationBuilderExtensions
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="app"></param>
        /// <param name="optionKey"></param>
        public static void UseTelegramBot(this IApplicationBuilder app, string botToken)
        {
            UseTelegramBot(app, botToken, TelegramBotConfig.DefaultOptions);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="app"></param>
        /// <param name="optionKey"></param>
        /// <param name="optionKey"></param>
        public static void UseTelegramBot(this IApplicationBuilder app, string botToken, string optionKey)
        {
            var option = TelegramBotConfig.GetOptions(optionKey);
            var servicesProvider = (TelegramBotAspNetCoreServicesProvider)option.ServicesProvider;
            servicesProvider.ServiceProvider = app.ApplicationServices;

            var config = new TelegramBotAppConfig();
            config.OptionsName = optionKey;
            config.Token = botToken;

            TelegramBotApplication.Run(config);
        }
    }
}
