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
        /// <param name="text"></param>
        /// <returns></returns>
        public void WithRequestContact(string text)
        {
            Button.Text = text;
            Button.RequestContact = true;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public void WithRequestLocation(string text)
        {
            Button.Text = text;
            Button.RequestLocation = true;
        }
    }
}
