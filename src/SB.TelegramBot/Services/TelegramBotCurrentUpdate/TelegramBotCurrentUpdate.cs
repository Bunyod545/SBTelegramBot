using SB.TelegramBot.Logics.TelegramBotDIContainers;
using Telegram.Bot.Types;

namespace SB.TelegramBot.Services
{
    /// <summary>
    /// 
    /// </summary>
    public class TelegramBotCurrentUpdate : ITelegramBotCurrentUpdate
    {
        /// <summary>
        /// 
        /// </summary>
        private Update _currentUpdate;

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public Update GetCurrentUpdate()
        {
            return _currentUpdate;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="update"></param>
        public void SetCurrentUpdate(Update update)
        {
            _currentUpdate = update;
        }
    }
}
