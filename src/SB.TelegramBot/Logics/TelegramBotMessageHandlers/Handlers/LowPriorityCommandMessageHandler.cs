using SB.TelegramBot.Logics.TelegramBotCommands.Factories;

namespace SB.TelegramBot
{
    /// <summary>
    /// 
    /// </summary>
    public class LowPriorityCommandMessageHandler : BaseCommandMessageHandler
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="context"></param>
        public override void Handle(MessageContext context)
        {
            if (string.IsNullOrEmpty(context.User.CurrentCommandClrName))
                return;

            var commandInfo = TelegramBotCommandFactory.GetPublicCommandInfo(context.Message.Text, context.UserRole);
            if (commandInfo == null)
                commandInfo = TelegramBotCommandFactory.GetPublicCommandInfo(context.Message.Text);

            if (commandInfo?.CommandName == null)
                return;

            var currentCommandInfo = TelegramBotCommandFactory.GetCommandInfoByClrName(context.User.CurrentCommandClrName);
            if (currentCommandInfo?.CommandName == null)
                return;

            if (!commandInfo.LowCommands.Contains(currentCommandInfo))
                return;

            var handlerCommand = TelegramBotCommandFactory.GetCommandInstance(commandInfo);
            ExecuteCommand(context, handlerCommand);
        }
    }
}
