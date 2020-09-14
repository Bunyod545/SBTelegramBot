using SB.TelegramBot.Logics.TelegramBotCallbackQueries;
using Telegram.Bot.Types;

namespace SB.TelegramBot.Services
{
    /// <summary>
    /// 
    /// </summary>
    public class TelegramBotCallbackQueryService : ITelegramBotCallbackQueryService
    {
        /// <summary>
        /// 
        /// </summary>
        public CallbackQuery CallbackQuery => TelegramBotCallbackQueryManager.CallbackQuery.Value;

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public virtual T GetData<T>() where T : class, new()
        {
            var data = CallbackQuery.Data;
            return TelegramBotCallbackDataConverter.Deserialize<T>(data);
        }
    }
}
