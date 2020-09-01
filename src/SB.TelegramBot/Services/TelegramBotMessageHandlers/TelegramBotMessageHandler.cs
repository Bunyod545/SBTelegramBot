using SB.TelegramBot.Databases.Tables;
using SB.TelegramBot.Helpers;
using SB.TelegramBot.Logics.TelegramBotCommands.Factories;
using SB.TelegramBot.Logics.TelegramBotDIContainers;
using SB.TelegramBot.Logics.TelegramBotMessages;
using System.Globalization;
using Telegram.Bot.Args;

namespace SB.TelegramBot.Services
{
    /// <summary>
    /// 
    /// </summary>
    public class TelegramBotMessageHandler : ITelegramBotMessageHandler
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void Handle(object sender, MessageEventArgs e)
        {
            TelegramBotMessageManager.Message.Value = e.Message;

            var userService = TelegramBotServicesContainer.GetService<ITelegramBotUserService>();
            var currentUser = userService.GetCurrentUserInfo();

            if (currentUser == null)
                currentUser = userService.RegisterUser();

            TelegramBotLanguageHelper.InitializeCulture(currentUser.Language);
            if (HandleBackCommand(currentUser, e))
                return;

            if (HandleCurrentCommand(currentUser))
                return;

            if (HandlePublicCommand(e))
                return;

            var unknownMessageService = TelegramBotServicesContainer.GetService<ITelegramBotUnknownMessageService>();
            unknownMessageService.Handle();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private bool HandleBackCommand(TelegramBotUserInfo user, MessageEventArgs e)
        {
            if (string.IsNullOrEmpty(user.BackCommandHandlerClrName))
                return false;

            var handler = TelegramBotCommandFactory.GetBackCommandHandler(user.BackCommandHandlerClrName);
            if (handler?.CommandName == null)
                return false;

            if (!handler.CommandName.IsEqualName(e.Message.Text))
                return false;

            var handlerCommand = TelegramBotCommandFactory.GetCommandInstance(handler);
            handlerCommand.Execute();
            return true;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private bool HandleCurrentCommand(TelegramBotUserInfo user)
        {
            if (string.IsNullOrEmpty(user.CurrentCommandClrName))
                return false;

            var currentCommand = TelegramBotCommandFactory.GetPublicOrInternalCommand(user.CurrentCommandClrName);
            currentCommand?.Execute();
            return true;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private bool HandlePublicCommand(MessageEventArgs e)
        {
            var command = TelegramBotCommandFactory.GetPublicCommand(e.Message.Text);
            if (command == null)
                return false;

            command.Execute();
            return true;
        }
    }
}
