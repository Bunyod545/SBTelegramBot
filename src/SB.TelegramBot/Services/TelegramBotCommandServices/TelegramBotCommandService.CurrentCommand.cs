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
        /// <typeparam name="TCommand"></typeparam>`
        /// <param name="chatId"></param>
        public virtual void SetCurrentCommand<TCommand>(long chatId) where TCommand : ITelegramBotCommand
        {
            var user = UserRepository.GetUserByChatId(chatId);
            if (user == null)
                return;

            user.CurrentCommandClrName = typeof(TCommand).Name;
            UserRepository.Update(user);
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
            var user = UserRepository.GetUserByChatId(chatId);
            if (user == null)
                return;

            user.CurrentCommandClrName = null;
            UserRepository.Update(user);
        }
    }
}
