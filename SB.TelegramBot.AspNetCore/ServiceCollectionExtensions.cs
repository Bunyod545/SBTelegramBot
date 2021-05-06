using SB.TelegramBot;
using SB.TelegramBot.AspNetCore;
using SB.TelegramBot.Logics.TelegramBotAutoDI;
using SB.TelegramBot.Logics.TelegramBotClients;
using SB.TelegramBot.Logics.TelegramBotCommands.Factories;
using SB.TelegramBot.Logics.TelegramBotConfigs;
using SB.TelegramBot.Logics.TelegramBotDIContainers;
using SB.TelegramBot.Services;

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

            var option = TelegramBotConfig.GetOptions(optionKey);
            option.Container = container;
            option.ServicesProvider = provider;

            services.AddSingleton<ITelegramBotServicesProvider>((s) => provider);
            container.AddSingleton<ITelegramBotClientManager, TelegramBotClientManager>();
            container.AddSingleton<ITelegramBotCommandFactory, TelegramBotCommandFactory>();
            container.AddSingleton<ITelegramBotMessageHandlerManager, TelegramBotMessageHandlerManager>();

            container.AddTransient<ITelegramBotCommandName, TelegramBotCommandName>();
            container.AddTransient<ITelegramBotCommandRole, TelegramBotCommandRole>();
            container.AddTransient<InlineKeyboardButtonBuilder, InlineKeyboardButtonBuilder>();
            container.AddTransient<KeyboardButtonBuilder, KeyboardButtonBuilder>();

            container.AddSingleton<ITelegramBotCommandFactoryInitializer, TelegramBotCommandFactoryInitializer>();
            container.AddScoped<ITelegramBotUserService, TelegramBotUserService>();
            container.AddScoped<ITelegramBotMessageService, TelegramBotMessageService>();
            container.AddScoped<ITelegramBotCallbackQueryService, TelegramBotCallbackQueryService>();
            container.AddScoped<ITelegramBotCommandActivator, TelegramBotCommandActivator>();
            container.AddScoped<ITelegramBotUnknownMessageService, TelegramBotUnknownMessageService>();

            container.AddScoped<ITelegramBotMessageHandler, TelegramBotMessageHandler>();
            container.AddScoped<ITelegramBotCallbackQueryHandler, TelegramBotCallbackQueryHandler>();
            container.AddScoped<ITelegramBotMessageEditedHandler, TelegramBotMessageEditedHandler>();
            container.AddScoped<ITelegramBotInlineQueryHandler, TelegramBotInlineQueryHandler>();
            container.AddScoped<ICommandMessageExceptionHandler, CommandMessageExceptionHandler>();

            TelegramBotAutoDIManager.Register(container);
        }
    }
}
