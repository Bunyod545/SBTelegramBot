using System.Threading;
using Telegram.Bot.Types;

namespace SB.TelegramBot.Logics.TelegramBotInlineQueries
{
    /// <summary>
    /// 
    /// </summary>
    public static class TelegramBotInlineQueryManager
    {
        /// <summary>
        /// 
        /// </summary>
        public readonly static AsyncLocal<InlineQuery> InlineQuery = new AsyncLocal<InlineQuery>();
    }
}
