using SB.TelegramBot.Logics.TelegramBotConfigs;
using SB.TelegramBot.Logics.TelegramBotDIContainers;
using System.Net.Http;

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
        public HttpClient HttpClient { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string OptionsName { get; set; } = TelegramBotConfig.DefaultOptions;

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
        /// <param name="app"></param>
        public virtual void Configure(TelegramBotApplication app)
        {

        }
    }
}
