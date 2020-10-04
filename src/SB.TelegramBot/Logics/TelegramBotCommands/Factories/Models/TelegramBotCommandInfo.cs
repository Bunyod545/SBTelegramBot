using SB.TelegramBot.Services;
using System;
using System.Collections.Generic;

namespace SB.TelegramBot.Logics.TelegramBotCommands.Factories.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class TelegramBotCommandInfo
    {
        /// <summary>
        /// 
        /// </summary>
        public string CommandClrName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public long CommandId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public bool IsHighestCommand { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public TelegramBotCommandType CommandType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public ITelegramBotCommandName CommandName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Type ClrType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public ITelegramBotCommandRole CommandRole { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public List<TelegramBotCommandInfo> LowCommands { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public List<TelegramBotCommandInfo> NearCommands { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public TelegramBotCommandInfo()
        {
            LowCommands = new List<TelegramBotCommandInfo>();
            NearCommands = new List<TelegramBotCommandInfo>();
        }
    }
}
