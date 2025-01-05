using Telegram.Bot.Types;

namespace SB.TelegramBot.Services
{
    /// <summary>
    /// 
    /// </summary>
    public interface ITelegramBotCurrentUpdate
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        Update GetCurrentUpdate();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="update"></param>
        /// <returns></returns>
        void SetCurrentUpdate(Update update);
    }
}
