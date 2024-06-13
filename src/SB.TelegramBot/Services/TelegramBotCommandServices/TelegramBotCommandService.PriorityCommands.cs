using SB.TelegramBot.Databases;
using SB.TelegramBot.Logics.TelegramBotCommands.Factories;
using System.Collections.Generic;

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
        public virtual void AddPriorityCommand<TCommand>() where TCommand : ITelegramBotCommand
        {
            AddPriorityCommand<TCommand>(ChatId);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TCommand"></typeparam>
        /// <param name="chatId"></param>
        public virtual void AddPriorityCommand<TCommand>(long chatId) where TCommand : ITelegramBotCommand
        {
            var user = UserRepository.GetUserByChatId(chatId);
            if (user == null)
                return;

            var command = TelegramBotCommandFactory.GetCommandInfo(typeof(TCommand));
            if (command == null)
                return;

            if (user.PriorityCommands == null)
                user.PriorityCommands = new List<long>();

            user.PriorityCommands.Add(command.CommandId);
            UserRepository.Update(user);
        }

        /// <summary>
        /// 
        /// </summary>
        public virtual void RemovePriorityCommand<TCommand>() where TCommand : ITelegramBotCommand
        {
            RemovePriorityCommand<TCommand>(ChatId);
        }

        /// <summary>
        /// 
        /// </summary>
        public virtual void RemovePriorityCommand<TCommand>(long chatId) where TCommand : ITelegramBotCommand
        {
            var user = UserRepository.GetUserByChatId(chatId);
            if (user == null)
                return;
            
            var command = TelegramBotCommandFactory.GetCommandInfo(typeof(TCommand));
            if (command == null)
                return;

            if (user.PriorityCommands == null)
                return;

            user.PriorityCommands.RemoveAll(r => r == command.CommandId);
            UserRepository.Update(user);
        }

        /// <summary>
        /// 
        /// </summary>
        public virtual void ClearPriorityCommands()
        {
            ClearPriorityCommands(ChatId);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="chatId"></param>
        public virtual void ClearPriorityCommands(long chatId)
        {
            var user = UserRepository.GetUserByChatId(chatId);
            if (user == null)
                return;

            user.PriorityCommands = null;
            UserRepository.Update(user);
        }
    }
}
