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
        private List<InlineKeyboardButton> _columnButtons;

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
            if (_columnButtons != null)
                EndOfColumn();
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
        public InlineKeyboardButtonInfo AddColumnButton()
        {
            if (_columnButtons == null)
                _columnButtons = new List<InlineKeyboardButton>();

            var currentButton = new InlineKeyboardButton();
            _columnButtons.Add(currentButton);
            return new InlineKeyboardButtonInfo(currentButton);
        }

        /// <summary>
        /// 
        /// </summary>
        public void EndOfColumn()
        {
            if (_columnButtons == null)
                return;

            if (_columnButtons.Count > 0)
                _buttons.Add(_columnButtons);

            _columnButtons = null;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public InlineKeyboardMarkup Build()
        {
            EndOfColumn();
            return new InlineKeyboardMarkup(_buttons);
        }
    }
}
