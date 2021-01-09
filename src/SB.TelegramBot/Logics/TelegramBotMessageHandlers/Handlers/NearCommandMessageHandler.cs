using SB.TelegramBot.Logics.TelegramBotCommands.Factories;
using System.Linq;

namespace SB.TelegramBot
{
    /// <summary>
    /// 
    /// </summary>
    public class NearCommandMessageHandler : BaseCommandMessageHandler
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="context"></param>
        public override void Handle(MessageContext context)
        {
            if (string.IsNullOrEmpty(context.User.CurrentCommandClrName))
                return;

            var currentCommandInfo = TelegramBotCommandFactory.GetCommandInfoByClrName(context.User.CurrentCommandClrName);
            if (currentCommandInfo == null)
                return;

            if (currentCommandInfo.NearCommands == null || !currentCommandInfo.NearCommands.Any())
                return;

            var command = currentCommandInfo.NearCommands.FirstOrDefault(f => f.CommandName.IsEqualName(context.Message.Text));
            if (command == null)
                return;

            var handlerCommand = TelegramBotCommandFactory.GetCommandInstance(command);
            ExecuteCommand(context, handlerCommand);
        }
    }
}
