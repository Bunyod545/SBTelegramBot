using System;
using System.Net.Http;
using Telegram.Bot;

namespace SB.TelegramBot.Logics.TelegramBotClients
{
    /// <summary>
    /// 
    /// </summary>
    public interface ITelegramBotClientManager : IDisposable
    {
        /// <summary>
        /// 
        /// </summary>
        string Token { get; set; }

        /// <summary>
        /// 
        /// </summary>
        HttpClient HttpClient { get; set; }

        /// <summary>
        /// 
        /// </summary>
        TelegramBotClient Client { get; set; }

        /// <summary>
        /// 
        /// </summary>
        void Initialize();
    }
}
