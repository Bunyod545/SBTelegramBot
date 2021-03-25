using Telegram.Bot.Types.ReplyMarkups;

namespace SB.TelegramBot.Logics.TelegramBotMarkupBuilders.KeyboardButtonBuilders.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class KeyboardButtonInfo
    {
        /// <summary>
        /// 
        /// </summary>
        public KeyboardButton Button { get; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="button"></param>
        public KeyboardButtonInfo(KeyboardButton button)
        {
            Button = button;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public void WithRequestContact()
        {
            Button.RequestContact = true;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public void WithRequestLocation()
        {
            Button.RequestLocation = true;
        }
    }
}
