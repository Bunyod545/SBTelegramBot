using SB.TelegramBot.Logics.TelegramBotCommands.Factories;

namespace SB.TelegramBot
{
    /// <summary>
    /// 
    /// </summary>
    public class HighestCommandMessageHandler : ICommandMessageHandler
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="context"></param>
        public void Handle(MessageContext context)
        {
            var commandInfo = TelegramBotCommandFactory.GetPublicCommandInfo(context.Message.Text, context.UserRole);
            if (commandInfo == null)
                commandInfo = TelegramBotCommandFactory.GetPublicCommandInfo(context.Message.Text);

            if (commandInfo == null)
                return;

            if (!commandInfo.IsHighestCommand)
                return;

            var handlerCommand = TelegramBotCommandFactory.GetCommandInstance(commandInfo);
            handlerCommand.Execute();
            context.MessageHandled();
        }
    }
}
