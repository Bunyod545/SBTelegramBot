using SB.TelegramBot.Databases;

namespace SB.TelegramBot.Services
{
    /// <summary>
    /// 
    /// </summary>
    public partial class TelegramBotCommandService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TCommand"></typeparam>
        public void SetCurrentCommand<TCommand>() where TCommand : ITelegramBotCommand
        {
            var user = TelegramBotDb.Users.FindOne(f => f.ChatId == MessageService.Message.Chat.Id);
            if (user == null)
                return;

            user.CurrentCommand = typeof(TCommand).Name;
            TelegramBotDb.Users.Update(user);
        }

        /// <summary>
        /// 
        /// </summary>
        public void ClearCurrentCommand()
        {
            var user = TelegramBotDb.Users.FindOne(f => f.ChatId == MessageService.Message.Chat.Id);
            if (user == null)
                return;

            user.CurrentCommand = null;
            TelegramBotDb.Users.Update(user);
        }
    }
}
