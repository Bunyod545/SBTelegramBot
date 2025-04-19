using SB.TelegramBot.Services;
using SB.TelegramBot.Services.TelegramBotBackCommands;
using System;
using System.Runtime.InteropServices;

namespace SB.TelegramBot
{
    /// <summary>
    /// 
    /// </summary>
    public class BackCommandMessageHandler : BaseCommandMessageHandler
    {
        /// <summary>
        /// 
        /// </summary>
        private ITelegramBotBackCommandName backCommandName;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="context"></param>
        public override void Handle(MessageContext context)
        {
            if (IsHandleByBackableCommand(context))
                return;

            if (string.IsNullOrEmpty(context.User.BackCommandHandlerClrName))
                return;

            var handler = TelegramBotCommandFactory.GetBackCommandHandler(context.User.BackCommandHandlerClrName);
            if (handler?.CommandName == null)
                return;

            if (!handler.CommandName.IsEqualName(context.Message.Text))
                return;

            var handlerCommand = TelegramBotCommandFactory.GetCommandInstance(handler);
            ExecuteCommand(context, handlerCommand);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        private bool IsHandleByBackableCommand(MessageContext context)
        {
            if (string.IsNullOrEmpty(context.User.CurrentCommandClrName))
                return false;

            var command = TelegramBotCommandFactory.GetPublicOrInternalCommandByClrName(context.User.CurrentCommandClrName);
            if (command == null)
                return false;

            var backableCommand = command as ITelegramBotBackableCommand;
            if (backableCommand == null)
                return false;

            var backCommandName = ServicesProvider.GetService<ITelegramBotBackCommandName>();
            if (backCommandName == null)
                return false;

            if (context.Message.Text != backCommandName.GetDefaultName())
                return false;

            try
            {
                PrePostExecute(context, command);
                backableCommand.HandleBack();
            }
            catch (Exception ex)
            {
                CatchExecuteCommand(context, command, ex);
            }

            return true;
        }
    }
}
