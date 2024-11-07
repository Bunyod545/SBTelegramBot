using SB.TelegramBot.Logics.TelegramBotClients;
using SB.TelegramBot.Logics.TelegramBotCommands.Factories;
using SB.TelegramBot.Logics.TelegramBotConfigs;
using SB.TelegramBot.Logics.TelegramBotDIContainers;
using System;
using System.Net.Http;

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
        private ITelegramBotServicesProvider _servicesProvider;

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
            _servicesProvider = options.ServicesProvider;

            options.ServicesRegistrator?.Register(_container, options);
            _container.Initialize();

            var commandFactory = _servicesProvider.GetService<ITelegramBotCommandFactory>();
            commandFactory.Initialize();
            AppConfig.Configure(this);

            var clientManager = _servicesProvider.GetService<ITelegramBotClientManager>();
            clientManager.Token = AppConfig.Token;
            clientManager.HttpClient = AppConfig.HttpClient;
            clientManager.Initialize();
        }

        /// <summary>
        /// 
        /// </summary>
        public virtual void Dispose()
        {
            var clientManager = _servicesProvider.GetService<ITelegramBotClientManager>();
            clientManager?.Dispose();
            _container?.Dispose();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="token"></param>
        /// <returns></returns>
        public static TelegramBotApplication Run(string token, HttpClient httpClient = null)
        {
            var config = new TelegramBotAppConfig(token);
            config.HttpClient = httpClient;

            return Run(config);
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
