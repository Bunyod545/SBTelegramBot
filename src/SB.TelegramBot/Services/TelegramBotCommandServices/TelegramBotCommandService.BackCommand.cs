using SB.TelegramBot.Databases;
using SB.TelegramBot.Logics.TelegramBotCommands.Factories;

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
        public virtual void SetBackCommand<TCommand>() where TCommand : ITelegramBotCommand
        {
            SetBackCommand<TCommand>(ChatId);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TCommand"></typeparam>
        /// <param name="chatId"></param>
        public virtual void SetBackCommand<TCommand>(long chatId) where TCommand : ITelegramBotCommand
        {
            var user = TelegramBotDb.Users.FindOne(f => f.ChatId == chatId);
            if (user == null)
                return;

            user.BackCommand = typeof(TCommand).Name;
            TelegramBotDb.Users.Update(user);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public virtual T GetBackCommand<T>() where T : class, ITelegramBotCommand
        {
            return GetBackCommand<T>(ChatId);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="chatId"></param>
        /// <returns></returns>
        public virtual T GetBackCommand<T>(long chatId) where T : class, ITelegramBotCommand
        {
            var user = TelegramBotDb.Users.FindOne(f => f.ChatId == chatId);
            if (user == null)
                return default(T);

            return TelegramBotCommandFactory.GetCommandByClrName(user.BackCommand) as T;
        }

        /// <summary>
        /// 
        /// </summary>
        public virtual void ExecuteBackCommand()
        {
            var backCommand = GetBackCommand<ITelegramBotCommand>();
            backCommand?.Execute();
        }

        /// <summary>
        /// 
        /// </summary>
        public virtual void ClearBackCommand()
        {
            ClearBackCommand(ChatId);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="chatId"></param>
        public virtual void ClearBackCommand(long chatId)
        {
            var user = TelegramBotDb.Users.FindOne(f => f.ChatId == chatId);
            if (user == null)
                return;

            user.BackCommand = null;
            TelegramBotDb.Users.Update(user);
        }
    }
}
