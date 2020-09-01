using SB.TelegramBot.Logics.TelegramBotCommands.Factories.Models;
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
        /// <param name="name"></param>
        /// <returns></returns>
        public static TelegramBotCommandInfo GetBackCommandHandler(string name)
        {
            return Infos.FirstOrDefault(s => s.CommandType == TelegramBotCommandType.BackCommand &&
                                             s.CommandClrName == name);
        }
    }
}
