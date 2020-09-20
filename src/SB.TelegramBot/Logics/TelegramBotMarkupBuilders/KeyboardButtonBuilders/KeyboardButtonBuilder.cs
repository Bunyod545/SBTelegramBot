using System.Collections.Generic;
using Telegram.Bot.Types.ReplyMarkups;

namespace SB.TelegramBot
{
    /// <summary>
    /// 
    /// </summary>
    public class KeyboardButtonBuilder
    {
        /// <summary>
        /// 
        /// </summary>
        private List<List<KeyboardButton>> _buttons;

        /// <summary>
        /// 
        /// </summary>
        private List<KeyboardButton> _columnButtons;

        /// <summary>
        /// 
        /// </summary>
        public KeyboardButtonBuilder()
        {
            _buttons = new List<List<KeyboardButton>>();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public KeyboardButtonBuilder AddRowButton(string text)
        {
            if (_columnButtons != null)
                EndOfColumn();
            var currentRowButtons = new List<KeyboardButton>();
            _buttons.Add(currentRowButtons);

            var currentButton = new KeyboardButton();
            currentButton.Text = text;
            currentRowButtons.Add(currentButton);
            return this;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public KeyboardButtonBuilder AddColumnButton(string text)
        {
            if (_columnButtons == null)
                _columnButtons = new List<KeyboardButton>();

            var currentButton = new KeyboardButton();
            currentButton.Text = text;
            _columnButtons.Add(currentButton);
            return this;
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
        public ReplyKeyboardMarkup Build()
        {
            EndOfColumn();
            return new ReplyKeyboardMarkup(_buttons);
        }
    }
}
