using SB.TelegramBot.Logics.TelegramBotCommands.Factories;

namespace SB.TelegramBot
{
    /// <summary>
    /// 
    /// </summary>
    public class CurrentCommandMessageHandler : BaseCommandMessageHandler
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="context"></param>
        public override void Handle(MessageContext context)
        {
            if (string.IsNullOrEmpty(context.User.CurrentCommandClrName))
                return;

            var currentCommand = TelegramBotCommandFactory.GetPublicOrInternalCommandByClrName(context.User.CurrentCommandClrName);
            ExecuteCommand(context, currentCommand);
        }
    }
}
