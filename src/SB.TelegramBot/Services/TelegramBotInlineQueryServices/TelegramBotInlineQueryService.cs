using SB.TelegramBot.Logics.TelegramBotInlineQueries;
using Telegram.Bot.Types;

namespace SB.TelegramBot.Services
{
    /// <summary>
    /// 
    /// </summary>
    public class TelegramBotInlineQueryService : ITelegramBotInlineQueryService
    {
        /// <summary>
        /// 
        /// </summary>
        public InlineQuery InlineQuery => TelegramBotInlineQueryManager.InlineQuery.Value;
    }
}
