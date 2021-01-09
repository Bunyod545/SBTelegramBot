using SB.TelegramBot.Logics.TelegramBotCommands.Factories;

namespace SB.TelegramBot
{
    /// <summary>
    /// 
    /// </summary>
    public class PublicCommandMessageHandler : BaseCommandMessageHandler
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="context"></param>
        public override void Handle(MessageContext context)
        {
            var command = TelegramBotCommandFactory.GetPublicCommand(context.Message.Text, context.UserRole);
            if (command == null)
                command = TelegramBotCommandFactory.GetPublicCommand(context.Message.Text);

            if (command == null)
                return;

            ExecuteCommand(context, command);
        }
    }
}
