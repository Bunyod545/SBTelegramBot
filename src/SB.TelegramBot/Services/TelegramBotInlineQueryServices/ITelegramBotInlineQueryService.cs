using Telegram.Bot.Types;

namespace SB.TelegramBot.Services
{
    /// <summary>
    /// 
    /// </summary>
    public interface ITelegramBotInlineQueryService
    {
        /// <summary>
        /// 
        /// </summary>
        InlineQuery InlineQuery { get; }
    }
}
