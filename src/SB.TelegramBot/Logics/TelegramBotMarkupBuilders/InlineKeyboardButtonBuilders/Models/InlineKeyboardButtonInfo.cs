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
        private InlineKeyboardButton _button;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="button"></param>
        public InlineKeyboardButtonInfo(InlineKeyboardButton button)
        {
            _button = button;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public InlineKeyboardButtonInfo WithText(string text)
        {
            _button.Text = text;
            return this;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public InlineKeyboardButtonInfo WithCommand<T>() where T : ITelegramBotCommand
        {
            _button.SetCommand<T>();
            return this;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public InlineKeyboardButtonInfo WithData(object data)
        {
            _button.SetData(data);
            return this;
        }
    }
}
