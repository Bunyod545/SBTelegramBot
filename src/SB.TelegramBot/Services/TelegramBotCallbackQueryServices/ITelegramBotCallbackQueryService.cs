using Telegram.Bot.Types;

namespace SB.TelegramBot.Services
{
    /// <summary>
    /// 
    /// </summary>
    public interface ITelegramBotCallbackQueryService
    {
        /// <summary>
        /// 
        /// </summary>
        CallbackQuery CallbackQuery { get; }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        T GetData<T>() where T : class, new();
    }
}
