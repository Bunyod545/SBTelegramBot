using SB.TelegramBot.Logics.TelegramBotCommands.Factories.Models;
using System;
using System.Linq;

namespace SB.TelegramBot.Logics.TelegramBotCommands.Factories
{
    /// <summary>
    /// 
    /// </summary>
    public static partial class TelegramBotCommandFactory
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="commandType"></param>
        /// <returns></returns>
        public static TelegramBotCommandInfo GetCommandInfo(Type commandType)
        {
            return Infos.FirstOrDefault(s => s.ClrType == commandType);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="clrName"></param>
        /// <returns></returns>
        public static TelegramBotCommandInfo GetCommandInfoByClrName(string clrName)
        {
            return Infos.FirstOrDefault(s => s.CommandClrName == clrName);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static ITelegramBotCommand GetCommand(string name)
        {
            var info = Infos.FirstOrDefault(s => s.CommandName != null && s.CommandName.IsEqualName(name));
            return GetCommandInstance(info);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="clrName"></param>
        /// <returns></returns>
        public static ITelegramBotCommand GetCommandByClrName(string clrName)
        {
            var info = Infos.FirstOrDefault(s => s.CommandClrName == clrName);
            return GetCommandInstance(info);
        }
    }
}
