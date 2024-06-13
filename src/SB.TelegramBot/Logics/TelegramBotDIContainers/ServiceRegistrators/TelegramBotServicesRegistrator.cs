using SB.TelegramBot.Logics.TelegramBotAutoDI;
using SB.TelegramBot.Logics.TelegramBotClients;
using SB.TelegramBot.Logics.TelegramBotCommands.Factories;
using SB.TelegramBot.Logics.TelegramBotConfigs;
using SB.TelegramBot.Repositories.UsersRepositories;
using SB.TelegramBot.Services;

namespace SB.TelegramBot.Logics.TelegramBotDIContainers
{
    /// <summary>
    /// 
    /// </summary>
    public class TelegramBotServicesRegistrator : ITelegramBotServicesRegistrator
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="servicesContainer"></param>
        /// <param name="options"></param>
        public void Register(ITelegramBotServicesContainer servicesContainer, TelegramBotOptions options)
        {
            servicesContainer.AddSingleton(() => options.ServicesProvider);
            servicesContainer.AddSingleton<ITelegramBotClientManager, TelegramBotClientManager>();
            servicesContainer.AddSingleton<ITelegramBotMessageHandlerManager, TelegramBotMessageHandlerManager>();
            servicesContainer.AddSingleton<ITelegramBotMessageHandler, TelegramBotMessageHandler>();
            servicesContainer.AddSingleton<ITelegramBotCommandFactory, TelegramBotCommandFactory>();
            servicesContainer.AddSingleton<ITelegramBotCommandFactoryInitializer, TelegramBotCommandFactoryInitializer>();

            servicesContainer.AddSingleton<ITelegramBotCallbackQueryHandler, TelegramBotCallbackQueryHandler>();
            servicesContainer.AddSingleton<ITelegramBotMessageEditedHandler, TelegramBotMessageEditedHandler>();
            servicesContainer.AddSingleton<ITelegramBotInlineQueryHandler, TelegramBotInlineQueryHandler>();
            servicesContainer.AddSingleton<ICommandMessageExceptionHandler, CommandMessageExceptionHandler>();

            servicesContainer.AddTransient<ITelegramBotCommandName, TelegramBotCommandName>();
            servicesContainer.AddTransient<ITelegramBotCommandRole, TelegramBotCommandRole>();
            servicesContainer.AddTransient<InlineKeyboardButtonBuilder, InlineKeyboardButtonBuilder>();
            servicesContainer.AddTransient<KeyboardButtonBuilder, KeyboardButtonBuilder>();

            servicesContainer.AddScoped<ITelegramBotCurrentCommand, TelegramBotCurrentCommand>();
            servicesContainer.AddScoped<ITelegramBotUserService, TelegramBotUserService>();
            servicesContainer.AddScoped<ITelegramBotUserRepository, TelegramBotUserRepository>();
            servicesContainer.AddScoped<ITelegramBotMessageService, TelegramBotMessageService>();
            servicesContainer.AddScoped<ITelegramBotCallbackQueryService, TelegramBotCallbackQueryService>();
            servicesContainer.AddScoped<ITelegramBotCommandActivator, TelegramBotCommandActivator>();
            servicesContainer.AddScoped<ITelegramBotUnknownMessageService, TelegramBotUnknownMessageService>();

            TelegramBotAutoDIManager.Register(servicesContainer);
        }
    }
}
