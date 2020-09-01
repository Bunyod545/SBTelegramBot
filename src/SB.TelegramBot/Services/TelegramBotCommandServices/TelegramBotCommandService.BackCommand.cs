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
        public void SetBackCommand<TCommand>() where TCommand : ITelegramBotCommand
        {
            var user = TelegramBotDb.Users.FindOne(f => f.ChatId == MessageService.Message.Chat.Id);
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
        public T GetBackCommand<T>() where T : class, ITelegramBotCommand
        {
            var user = TelegramBotDb.Users.FindOne(f => f.ChatId == MessageService.Message.Chat.Id);
            if (user == null)
                return default(T);

            return TelegramBotCommandFactory.GetCommandByClrName(user.BackCommand) as T;
        }

        /// <summary>
        /// 
        /// </summary>
        public void ExecuteBackCommand()
        {
            var backCommand = GetBackCommand<ITelegramBotCommand>();
            backCommand?.Execute();
        }

        /// <summary>
        /// 
        /// </summary>
        public void ClearBackCommand()
        {
            var user = TelegramBotDb.Users.FindOne(f => f.ChatId == MessageService.Message.Chat.Id);
            if (user == null)
                return;

            user.BackCommand = null;
            TelegramBotDb.Users.Update(user);
        }
    }
}
