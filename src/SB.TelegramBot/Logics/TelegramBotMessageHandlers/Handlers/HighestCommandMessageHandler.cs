using SB.TelegramBot.Logics.TelegramBotCommands.Factories;

namespace SB.TelegramBot
{
    /// <summary>
    /// 
    /// </summary>
    public class HighestCommandMessageHandler : BaseCommandMessageHandler
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="context"></param>
        public override void Handle(MessageContext context)
        {
            var commandInfo = TelegramBotCommandFactory.GetPublicCommandInfo(context.Message.Text, context.UserRole);
            if (commandInfo == null)
                commandInfo = TelegramBotCommandFactory.GetPublicCommandInfo(context.Message.Text);

            if (commandInfo == null)
                return;

            if (!commandInfo.IsHighestCommand)
                return;

            var handlerCommand = TelegramBotCommandFactory.GetCommandInstance(commandInfo);
            ExecuteCommand(context, handlerCommand);
        }
    }
}
