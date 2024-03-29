using SB.TelegramBot.Helpers;
using SB.TelegramBot.Logics.TelegramBotCallbackQueries;
using SB.TelegramBot.Logics.TelegramBotCommands.Factories;
using SB.TelegramBot.Logics.TelegramBotDIContainers;
using SB.TelegramBot.Logics.TelegramBotMessages;
using Telegram.Bot.Args;
using Telegram.Bot.Types;

namespace SB.TelegramBot.Services
{
    /// <summary>
    /// 
    /// </summary>
    public class TelegramBotCallbackQueryHandler : ITelegramBotCallbackQueryHandler
    {
        /// <summary>
        /// 
        /// </summary>
        protected ITelegramBotServicesProvider TelegramBotServicesContainer { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        protected ITelegramBotCommandFactory TelegramBotCommandFactory { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="telegramBotServicesContainer"></param>
        /// <param name="telegramBotCommandFactory"></param>
        public TelegramBotCallbackQueryHandler(ITelegramBotServicesProvider telegramBotServicesContainer, ITelegramBotCommandFactory telegramBotCommandFactory)
        {
            TelegramBotServicesContainer = telegramBotServicesContainer;
            TelegramBotCommandFactory = telegramBotCommandFactory;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public virtual void Handle(object sender, Update e)
        {
            TelegramBotServicesContainer.RequestBegin();
            InternalHandle(sender, e);
            TelegramBotServicesContainer.RequestEnd();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected virtual void InternalHandle(object sender, Update e)
        {
            TelegramBotMessageManager.Message.Value = e.CallbackQuery.Message;

            var userService = TelegramBotServicesContainer.GetService<ITelegramBotUserService>();
            var currentUser = userService.GetCurrentUserInfo();

            if (currentUser == null)
                currentUser = userService.RegisterUser();

            TelegramBotLanguageHelper.InitializeCulture(currentUser.Language);
            var commandId = GetCommandId(e.CallbackQuery.Data);
            if (commandId == null)
                return;

            var command = TelegramBotCommandFactory.GetCallbackCommand(commandId.Value);
            if (command == null)
                return;

            e.CallbackQuery.Data = RemoveCommandId(e.CallbackQuery.Data);
            TelegramBotCallbackQueryManager.CallbackQuery.Value = e.CallbackQuery;
            command.Execute();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        protected virtual long? GetCommandId(string data)
        {
            if (string.IsNullOrEmpty(data))
                return null;

            var datas = data.Split(';');
            if (datas.Length == 0)
                return null;

            var firstData = datas[0];
            return long.TryParse(firstData, out var id) ? id : (long?)null;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        protected virtual string RemoveCommandId(string data)
        {
            var index = data.IndexOf(';');
            return data.Substring(index + 1);
        }
    }
}
