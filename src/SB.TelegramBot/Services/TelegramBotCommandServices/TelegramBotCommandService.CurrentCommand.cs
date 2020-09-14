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
        public virtual void SetCurrentCommand<TCommand>() where TCommand : ITelegramBotCommand
        {
            SetCurrentCommand<TCommand>(ChatId);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TCommand"></typeparam>
        /// <param name="chatId"></param>
        public virtual void SetCurrentCommand<TCommand>(long chatId) where TCommand : ITelegramBotCommand
        {
            var user = TelegramBotDb.Users.FindOne(f => f.ChatId == chatId);
            if (user == null)
                return;

            user.CurrentCommand = typeof(TCommand).Name;
            TelegramBotDb.Users.Update(user);
        }

        /// <summary>
        /// 
        /// </summary>
        public virtual void ClearCurrentCommand()
        {
            ClearCurrentCommand(ChatId);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="chatId"></param>
        public virtual void ClearCurrentCommand(long chatId)
        {
            var user = TelegramBotDb.Users.FindOne(f => f.ChatId == chatId);
            if (user == null)
                return;

            user.CurrentCommand = null;
            TelegramBotDb.Users.Update(user);
        }
    }
}
