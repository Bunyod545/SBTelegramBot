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
        public virtual void SetBackCommandHandler<TCommand>() where TCommand : ITelegramBotCommand
        {
            SetBackCommandHandler<TCommand>(ChatId);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TCommand"></typeparam>
        /// <param name="chatId"></param>
        public virtual void SetBackCommandHandler<TCommand>(long chatId) where TCommand : ITelegramBotCommand
        {
            var user = UserRepository.GetUserByChatId(chatId);
            if (user == null)
                return;

            user.BackCommandHandler = typeof(TCommand).Name;
            UserRepository.Update(user);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public virtual T GetBackCommandHandler<T>() where T : class, ITelegramBotCommand
        {
            return GetBackCommandHandler<T>(ChatId);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="chatId"></param>
        /// <returns></returns>
        public virtual T GetBackCommandHandler<T>(long chatId) where T : class, ITelegramBotCommand
        {
            var user = UserRepository.GetUserByChatId(chatId);
            if (user == null)
                return default(T);

            return TelegramBotCommandFactory.GetCommandByClrName(user.BackCommandHandler) as T;
        }

        /// <summary>
        /// 
        /// </summary>
        public virtual void ExecuteBackCommandHandler()
        {
            var backCommand = GetBackCommandHandler<ITelegramBotCommand>();
            backCommand?.Execute();
        }

        /// <summary>
        /// 
        /// </summary>
        public virtual void ClearBackCommandHandler()
        {
            ClearBackCommandHandler(ChatId);
        }

        /// <summary>
        /// 
        /// </summary>
        public virtual void ClearBackCommandHandler(long chatId)
        {
            var user = UserRepository.GetUserByChatId(chatId);
            if (user == null)
                return;

            user.BackCommandHandler = null;
            UserRepository.Update(user);
        }
    }
}
