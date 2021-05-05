using SB.TelegramBot.Logics.TelegramBotAutoDI;
using SB.TelegramBot.Logics.TelegramBotClients;
using SB.TelegramBot.Logics.TelegramBotCommands.Factories;
using SB.TelegramBot.Logics.TelegramBotConfigs;
using SB.TelegramBot.Logics.TelegramBotDIContainers;
using SB.TelegramBot.Services;
using System;

namespace SB.TelegramBot
{
    /// <summary>
    /// 
    /// </summary>
    public class TelegramBotApplication : IDisposable
    {
        /// <summary>
        /// 
        /// </summary>
        private ITelegramBotServicesContainer _container;

        /// <summary>
        /// 
        /// </summary>
        public const string Version = "1.0.0.0";

        /// <summary>
        /// 
        /// </summary>
        public TelegramBotAppConfig AppConfig { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="appConfig"></param>
        public TelegramBotApplication(TelegramBotAppConfig appConfig)
        {
            AppConfig = appConfig;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="token"></param>
        public TelegramBotApplication(string token)
        {
            AppConfig = new TelegramBotAppConfig(token);
        }

        /// <summary>
        /// 
        /// </summary>
        public virtual void Run()
        {
            var options = TelegramBotConfig.GetOptions(AppConfig.OptionsName);
            if (options == null)
                throw new Exception($"Telegram bot options not configured! Options name: {AppConfig.OptionsName}");

            _container = options.Container;
            RegisterServices(_container);
            _container.Initialize();

            var commandFactory = _container.GetService<ITelegramBotCommandFactory>();
            commandFactory.Initialize();

            AppConfig.Configure(this);

            var clientManager = _container.GetService<ITelegramBotClientManager>();
            clientManager.Token = AppConfig.Token;
            clientManager.Initialize();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="services"></param>
        protected virtual void RegisterServices(ITelegramBotServicesContainer services)
        {
            services.AddSingleton(services);
            services.AddSingleton<ITelegramBotClientManager, TelegramBotClientManager>();
            services.AddSingleton<ITelegramBotCommandFactory, TelegramBotCommandFactory>();
            services.AddSingleton<ITelegramBotMessageHandlerManager, TelegramBotMessageHandlerManager>();

            services.AddTransient<ITelegramBotCommandName, TelegramBotCommandName>();
            services.AddTransient<ITelegramBotCommandRole, TelegramBotCommandRole>();
            services.AddTransient<InlineKeyboardButtonBuilder, InlineKeyboardButtonBuilder>();
            services.AddTransient<KeyboardButtonBuilder, KeyboardButtonBuilder>();

            services.AddScoped<ITelegramBotCommandFactoryInitializer, TelegramBotCommandFactoryInitializer>();
            services.AddScoped<ITelegramBotUserService, TelegramBotUserService>();
            services.AddScoped<ITelegramBotMessageService, TelegramBotMessageService>();
            services.AddScoped<ITelegramBotCallbackQueryService, TelegramBotCallbackQueryService>();
            services.AddScoped<ITelegramBotCommandActivator, TelegramBotCommandActivator>();
            services.AddScoped<ITelegramBotUnknownMessageService, TelegramBotUnknownMessageService>();

            services.AddScoped<ITelegramBotMessageHandler, TelegramBotMessageHandler>();
            services.AddScoped<ITelegramBotCallbackQueryHandler, TelegramBotCallbackQueryHandler>();
            services.AddScoped<ITelegramBotMessageEditedHandler, TelegramBotMessageEditedHandler>();
            services.AddScoped<ITelegramBotInlineQueryHandler, TelegramBotInlineQueryHandler>();
            services.AddScoped<ICommandMessageExceptionHandler, CommandMessageExceptionHandler>();

            TelegramBotAutoDIManager.Register(services);
            AppConfig.RegisterServices(services);
        }

        /// <summary>
        /// 
        /// </summary>
        public virtual void Dispose()
        {
            var clientManager = _container.GetService<ITelegramBotClientManager>();
            clientManager?.Dispose();
            _container?.Dispose();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="token"></param>
        /// <returns></returns>
        public static TelegramBotApplication Run(string token)
        {
            var telegramBotApp = new TelegramBotApplication(token);
            telegramBotApp.Run();

            return telegramBotApp;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="appConfig"></param>
        /// <returns></returns>
        public static TelegramBotApplication Run(TelegramBotAppConfig appConfig)
        {
            var telegramBotApp = new TelegramBotApplication(appConfig);
            telegramBotApp.Run();

            return telegramBotApp;
        }
    }
}
