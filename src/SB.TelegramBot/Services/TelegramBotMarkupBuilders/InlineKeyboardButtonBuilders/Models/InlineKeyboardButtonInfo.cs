using SB.TelegramBot.Logics.TelegramBotCommands.Factories;
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
        public ITelegramBotCommandFactory CommandFactory { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="button"></param>
        /// <param name="commandFactory"></param>
        public InlineKeyboardButtonInfo(InlineKeyboardButton button, ITelegramBotCommandFactory commandFactory)
        {
            Button = button;
            CommandFactory = commandFactory;
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
            var commandInfo = CommandFactory.GetCommandInfo(typeof(T));
            if (commandInfo == null)
                return this;

            Button.CallbackData = $"{commandInfo.CommandId};" + Button.CallbackData;
            return this;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public InlineKeyboardButtonInfo WithData(object data)
        {
            var dataString = TelegramBotCallbackDataConverter.Serialize(data);
            Button.CallbackData += dataString;
            return this;
        }
    }
}
