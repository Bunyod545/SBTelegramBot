using SB.TelegramBot.Logics.TelegramBotConfigs;
using SB.TelegramBot.Logics.TelegramBotDIContainers;

namespace SB.TelegramBot
{
    /// <summary>
    /// 
    /// </summary>
    public class TelegramBotAppConfig
    {
        /// <summary>
        /// 
        /// </summary>
        public string Token { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string OptionsName = TelegramBotConfig.DefaultOptions;

        /// <summary>
        /// 
        /// </summary>
        public TelegramBotAppConfig()
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="token"></param>
        public TelegramBotAppConfig(string token)
        {
            Token = token;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="services"></param>
        public virtual void RegisterServices(ITelegramBotServicesContainer services)
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="app"></param>
        public virtual void Configure(TelegramBotApplication app)
        {

        }
    }
}
