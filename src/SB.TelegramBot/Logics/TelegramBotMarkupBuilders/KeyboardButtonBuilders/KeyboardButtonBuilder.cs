using System.Collections.Generic;
using SB.TelegramBot.Logics.TelegramBotMarkupBuilders.KeyboardButtonBuilders.Models;
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
        private bool _isResize = true;

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
        public KeyboardButtonInfo AddRowButton(string text)
        {
            if (_columnButtons != null)
                EndOfColumn();

            var currentRowButtons = new List<KeyboardButton>();
            _buttons.Add(currentRowButtons);

            var currentButton = new KeyboardButton();
            currentButton.Text = text;
            currentRowButtons.Add(currentButton);
            return new KeyboardButtonInfo(currentButton);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public KeyboardButtonInfo AddColumnButton(string text)
        {
            if (_columnButtons == null)
                _columnButtons = new List<KeyboardButton>();

            var currentButton = new KeyboardButton();
            currentButton.Text = text;
            _columnButtons.Add(currentButton);
            return new KeyboardButtonInfo(currentButton);
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
        /// <param name="isCanResize"></param>
        /// <returns></returns>
        public KeyboardButtonBuilder IsCanResize(bool isCanResize)
        {
            _isResize = isCanResize;
            return this;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public ReplyKeyboardMarkup Build()
        {
            EndOfColumn();

            var markup = new ReplyKeyboardMarkup(_buttons);
            markup.ResizeKeyboard = _isResize;
            return markup;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="builder"></param>
        public static implicit operator ReplyKeyboardMarkup(KeyboardButtonBuilder builder)
        {
            return builder.Build();
        }
    }
}