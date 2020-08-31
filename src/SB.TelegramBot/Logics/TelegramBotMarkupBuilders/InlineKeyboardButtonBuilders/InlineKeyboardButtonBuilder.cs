using System.Collections.Generic;
using Telegram.Bot.Types.ReplyMarkups;

namespace SB.TelegramBot
{
    /// <summary>
    /// 
    /// </summary>
    public class InlineKeyboardButtonBuilder
    {
        /// <summary>
        /// 
        /// </summary>
        private List<List<InlineKeyboardButton>> _buttons;

        /// <summary>
        /// 
        /// </summary>
        public InlineKeyboardButtonBuilder()
        {
            _buttons = new List<List<InlineKeyboardButton>>();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public InlineKeyboardButtonInfo AddRowButton()
        {
            var currentRowButtons = new List<InlineKeyboardButton>();
            _buttons.Add(currentRowButtons);

            var currentButton = new InlineKeyboardButton();
            currentRowButtons.Add(currentButton);
            return new InlineKeyboardButtonInfo(currentButton);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public IReplyMarkup Build()
        {
            return new InlineKeyboardMarkup(_buttons);
        }
    }
}
