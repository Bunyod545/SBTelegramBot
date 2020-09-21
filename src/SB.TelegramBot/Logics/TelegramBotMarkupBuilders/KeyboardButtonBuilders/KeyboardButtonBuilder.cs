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
        public KeyboardButtonBuilder AddRowButton(string text)
        {
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
        /// <param name="isResize"></param>
        /// <returns></returns>
        public KeyboardButtonBuilder Resize(bool isResize)
        {
            _isResize = isResize;
            return this;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public ReplyKeyboardMarkup Build()
        {
            var markup = new ReplyKeyboardMarkup(_buttons);
            markup.ResizeKeyboard = _isResize; 

            return markup;
        }
    }
}