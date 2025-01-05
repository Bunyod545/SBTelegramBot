using SB.TelegramBot.Logics.TelegramBotCommands.Factories.Models;
using System.Linq;

namespace SB.TelegramBot.Logics.TelegramBotCommands.Factories
{
    /// <summary>
    /// 
    /// </summary>
    public partial class TelegramBotCommandFactory
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public TelegramBotCommandInfo GetPollCommandHandler(string name)
        {
            return Infos.FirstOrDefault(s => s.CommandType == TelegramBotCommandType.PollCommand &&
                                             s.CommandClrName == name);
        }
    }
}
