using Telegram.Bot.Types.ReplyMarkups;

namespace SB.TelegramBot
{
    /// <summary>
    /// 
    /// </summary>
    public class InlineKeyboardButtonInfo
    {
        /// <summary>
        /// 
        /// </summary>
        public InlineKeyboardButton Button { get; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="button"></param>
        public InlineKeyboardButtonInfo(InlineKeyboardButton button)
        {
            Button = button;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public InlineKeyboardButtonInfo WithText(string text)
        {
            Button.Text = text;
            return this;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public InlineKeyboardButtonInfo WithCommand<T>() where T : ITelegramBotCommand
        {
            Button.SetCommand<T>();
            return this;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public InlineKeyboardButtonInfo WithData(object data)
        {
            Button.SetData(data);
            return this;
        }
    }
}
