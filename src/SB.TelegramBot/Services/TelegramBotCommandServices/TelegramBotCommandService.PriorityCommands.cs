﻿using SB.TelegramBot.Databases;
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
            var user = TelegramBotDb.Users.FindOne(f => f.ChatId == chatId);
            if (user == null)
                return;

            var command = TelegramBotCommandFactory.GetCommandInfo(typeof(TCommand));
            if (command == null)
                return;

            if (user.PriorityCommands == null)
                user.PriorityCommands = new List<long>();

            user.PriorityCommands.Add(command.CommandId);
            TelegramBotDb.Users.Update(user);
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
            var user = TelegramBotDb.Users.FindOne(f => f.ChatId == chatId);
            if (user == null)
                return;

            user.PriorityCommands = null;
            TelegramBotDb.Users.Update(user);
        }
    }
}