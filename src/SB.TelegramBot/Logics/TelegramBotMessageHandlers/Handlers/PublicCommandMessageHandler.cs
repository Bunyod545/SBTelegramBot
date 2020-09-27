using SB.TelegramBot.Logics.TelegramBotCommands.Factories;

namespace SB.TelegramBot
{
    /// <summary>
    /// 
    /// </summary>
    public class PublicCommandMessageHandler : ICommandMessageHandler
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="context"></param>
        public void Handle(MessageContext context)
        {
            var command = TelegramBotCommandFactory.GetPublicCommand(context.Message.Text, context.UserRole);
            if (command == null)
                command = TelegramBotCommandFactory.GetPublicCommand(context.Message.Text);

            if (command == null)
                return;

            command.Execute();
            context.MessageHandled();
        }
    }
}
