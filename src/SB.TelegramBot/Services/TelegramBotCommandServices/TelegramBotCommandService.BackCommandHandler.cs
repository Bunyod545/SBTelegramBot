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
        public void SetBackCommandHandler<TCommand>() where TCommand : ITelegramBotCommand
        {
            var user = TelegramBotDb.Users.FindOne(f => f.ChatId == MessageService.Message.Chat.Id);
            if (user == null)
                return;

            user.BackCommandHandler = typeof(TCommand).Name;
            TelegramBotDb.Users.Update(user);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public T GetBackCommandHandler<T>() where T : class, ITelegramBotCommand
        {
            var user = TelegramBotDb.Users.FindOne(f => f.ChatId == MessageService.Message.Chat.Id);
            if (user == null)
                return default(T);

            return TelegramBotCommandFactory.GetCommandByClrName(user.BackCommandHandler) as T;
        }

        /// <summary>
        /// 
        /// </summary>
        public void ExecuteBackCommandHandler()
        {
            var backCommand = GetBackCommandHandler<ITelegramBotCommand>();
            backCommand?.Execute();
        }

        /// <summary>
        /// 
        /// </summary>
        public void ClearBackCommandHandler()
        {
            var user = TelegramBotDb.Users.FindOne(f => f.ChatId == MessageService.Message.Chat.Id);
            if (user == null)
                return;

            user.BackCommandHandler = null;
            TelegramBotDb.Users.Update(user);
        }
    }
}
