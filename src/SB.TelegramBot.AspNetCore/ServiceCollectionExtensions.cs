using SB.TelegramBot.AspNetCore;
using SB.TelegramBot.Logics.TelegramBotConfigs;

namespace Microsoft.Extensions.DependencyInjection
{
    /// <summary>
    /// 
    /// </summary>
    public static class ServiceCollectionExtensions
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="services"></param>
        public static void AddTelegramBot(this IServiceCollection services)
        {
            AddTelegramBot(services, TelegramBotConfig.DefaultOptions);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="services"></param>
        public static void AddTelegramBot(this IServiceCollection services, string optionKey)
        {
            var container = new TelegramBotAspNetCoreServicesContainer(services);
            var provider = new TelegramBotAspNetCoreServicesProvider();

            var options = TelegramBotConfig.GetOptions(optionKey);
            options.Container = container;
            options.ServicesProvider = provider;

            options.ServicesRegistrator.Register(container, options);
            options.ServicesRegistrator = null;
        }
    }
}
