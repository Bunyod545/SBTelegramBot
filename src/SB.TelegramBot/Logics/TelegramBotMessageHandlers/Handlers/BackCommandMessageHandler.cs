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
            if (string.IsNullOrEmpty(context.User.BackCommandClrName))
                return;

            var currentCommand = TelegramBotCommandFactory.GetPublicOrInternalCommand(context.User.CurrentCommandClrName);
            currentCommand?.Execute();
            context.MessageHandled();
        }
    }
}
