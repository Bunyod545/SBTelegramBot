using SB.TelegramBot.Logics.TelegramBotCommands.Factories;

namespace SB.TelegramBot
{
    /// <summary>
    /// 
    /// </summary>
    public class CurrentCommandMessageHandler : ICommandMessageHandler
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="context"></param>
        public void Handle(MessageContext context)
        {
            if (string.IsNullOrEmpty(context.User.CurrentCommandClrName))
                return;

            var currentCommand = TelegramBotCommandFactory.GetPublicOrInternalCommand(context.User.CurrentCommandClrName);
            currentCommand?.Execute();
            context.MessageHandled();
        }
    }
}
