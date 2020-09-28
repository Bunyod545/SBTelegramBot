using SB.TelegramBot.Logics.TelegramBotCommands.Factories;

namespace SB.TelegramBot
{
    /// <summary>
    /// 
    /// </summary>
    public class BackCommandMessageHandler : ICommandMessageHandler
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="context"></param>
        public void Handle(MessageContext context)
        {
            if (string.IsNullOrEmpty(context.User.BackCommandHandlerClrName))
                return;

            var handler = TelegramBotCommandFactory.GetBackCommandHandler(context.User.BackCommandHandlerClrName);
            if (handler?.CommandName == null)
                return;

            if (!handler.CommandName.IsEqualName(context.Message.Text))
                return;

            var handlerCommand = TelegramBotCommandFactory.GetCommandInstance(handler);
            handlerCommand.Execute();
            context.MessageHandled();
        }
    }
}
