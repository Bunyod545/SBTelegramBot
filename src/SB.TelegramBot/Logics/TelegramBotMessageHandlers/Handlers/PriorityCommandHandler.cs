using SB.TelegramBot.Logics.TelegramBotCommands.Factories;
using System.Linq;

namespace SB.TelegramBot
{
    /// <summary>
    /// 
    /// </summary>
    public class PriorityCommandHandler : BaseCommandMessageHandler
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="context"></param>
        public override void Handle(MessageContext context)
        {
            var priorityCommands = context.User.PriorityCommands;
            if (priorityCommands == null || !priorityCommands.Any())
                return;

            var priorityCommand = GetPriorityCommand(context);
            if (priorityCommand == null)
                return;

            ExecuteCommand(context, priorityCommand);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private ITelegramBotCommand GetPriorityCommand(MessageContext context)
        {
            var priorityCommands = context.User.PriorityCommands;
            var commands = TelegramBotCommandFactory
                .GetCommands()
                .Where(w => w.CommandType == TelegramBotCommandType.PublicCommand)
                .Where(w => priorityCommands.Contains(w.CommandId))
                .Where(w => w.CommandRole.IsEqualRole(context.UserRole))
                .ToList();

            if (!commands.Any())
                return null;

            var command = commands.FirstOrDefault(f => f.CommandName.IsEqualName(context.Message.Text));
            if (command == null)
                return null;

            return TelegramBotCommandFactory.GetCommandInstance(command);
        }
    }
}