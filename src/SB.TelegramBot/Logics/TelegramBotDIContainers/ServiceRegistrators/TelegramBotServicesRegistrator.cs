﻿using SB.TelegramBot.Logics.TelegramBotAutoDI;
using SB.TelegramBot.Logics.TelegramBotClients;
using SB.TelegramBot.Logics.TelegramBotCommands.Factories;
using SB.TelegramBot.Logics.TelegramBotConfigs;
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
            servicesContainer.AddSingleton<ITelegramBotCommandFactory, TelegramBotCommandFactory>();
            servicesContainer.AddSingleton<ITelegramBotMessageHandlerManager, TelegramBotMessageHandlerManager>();
            servicesContainer.AddSingleton<ITelegramBotMessageHandler, TelegramBotMessageHandler>();

            servicesContainer.AddTransient<ITelegramBotCommandName, TelegramBotCommandName>();
            servicesContainer.AddTransient<ITelegramBotCommandRole, TelegramBotCommandRole>();
            servicesContainer.AddTransient<InlineKeyboardButtonBuilder, InlineKeyboardButtonBuilder>();
            servicesContainer.AddTransient<KeyboardButtonBuilder, KeyboardButtonBuilder>();

            servicesContainer.AddSingleton<ITelegramBotCommandFactoryInitializer, TelegramBotCommandFactoryInitializer>();
            servicesContainer.AddScoped<ITelegramBotUserService, TelegramBotUserService>();
            servicesContainer.AddScoped<ITelegramBotMessageService, TelegramBotMessageService>();
            servicesContainer.AddScoped<ITelegramBotCallbackQueryService, TelegramBotCallbackQueryService>();
            servicesContainer.AddScoped<ITelegramBotCommandActivator, TelegramBotCommandActivator>();
            servicesContainer.AddScoped<ITelegramBotUnknownMessageService, TelegramBotUnknownMessageService>();

            servicesContainer.AddScoped<ITelegramBotCallbackQueryHandler, TelegramBotCallbackQueryHandler>();
            servicesContainer.AddScoped<ITelegramBotMessageEditedHandler, TelegramBotMessageEditedHandler>();
            servicesContainer.AddScoped<ITelegramBotInlineQueryHandler, TelegramBotInlineQueryHandler>();
            servicesContainer.AddScoped<ICommandMessageExceptionHandler, CommandMessageExceptionHandler>();

            TelegramBotAutoDIManager.Register(servicesContainer);
        }
    }
}