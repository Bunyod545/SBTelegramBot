using SB.TelegramBot.Logics.TelegramBotCommands.Factories;
using SB.TelegramBot.Repositories.CallbackDataRepositories;
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
        /// <summary>
        /// 
        /// </summary>
        public ITelegramBotCommandFactory CommandFactory { get; }

        /// <summary>
        /// 
        /// </summary>
        public ITelegramBotCallbackDataRepository CallbackDataRepository { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="commandFactory"></param>
        /// <param name="callbackDataRepository"></param>
        public InlineKeyboardButtonBuilder(ITelegramBotCommandFactory commandFactory,
            ITelegramBotCallbackDataRepository callbackDataRepository)
        {
            _buttons = new List<List<InlineKeyboardButton>>();
            CommandFactory = commandFactory;
            CallbackDataRepository = callbackDataRepository;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public virtual InlineKeyboardButtonInfo AddRowButton()
        {
            if (_columnButtons != null)
                EndOfColumn();

            var currentRowButtons = new List<InlineKeyboardButton>();
            _buttons.Add(currentRowButtons);

            var currentButton = new InlineKeyboardButton(string.Empty);
            currentRowButtons.Add(currentButton);
            return new InlineKeyboardButtonInfo(currentButton, CommandFactory, CallbackDataRepository);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public virtual InlineKeyboardButtonInfo AddColumnButton()
        {
            if (_columnButtons == null)
                _columnButtons = new List<InlineKeyboardButton>();

            var currentButton = new InlineKeyboardButton(string.Empty);
            _columnButtons.Add(currentButton);
            return new InlineKeyboardButtonInfo(currentButton, CommandFactory, CallbackDataRepository);
        }

        /// <summary>
        /// 
        /// </summary>
        public virtual void EndOfColumn()
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
        public virtual InlineKeyboardMarkup Build()
        {
            EndOfColumn();
            return new InlineKeyboardMarkup(_buttons);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public virtual int ColumnButtonsCount()
        {
            return _columnButtons.Count;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public virtual int RowButtonsCount()
        {
            return _buttons.Count;
        }
    }
}