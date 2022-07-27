using SB.TelegramBot.Logics.TelegramBotCommands.Factories;
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
        private ITelegramBotCommandFactory _commandFactory;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="commandFactory"></param>
        public KeyboardButtonBuilder(ITelegramBotCommandFactory commandFactory)
        {
            _commandFactory = commandFactory;
            _buttons = new List<List<KeyboardButton>>();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public KeyboardButtonInfo AddRowButton<TCommand>() where TCommand : ITelegramBotCommand
        {
            var commandInfo = _commandFactory.GetCommandInfo(typeof(TCommand));
            return AddRowButton(commandInfo?.CommandName?.GetName());
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

            var currentButton = new KeyboardButton(text);
            currentButton.Text = text;
            currentRowButtons.Add(currentButton);
            return new KeyboardButtonInfo(currentButton);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public KeyboardButtonInfo AddColumnButton<TCommand>() where TCommand : ITelegramBotCommand
        {
            var commandInfo = _commandFactory.GetCommandInfo(typeof(TCommand));
            return AddColumnButton(commandInfo?.CommandName?.GetName());
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

            var currentButton = new KeyboardButton(text);
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
    }
}