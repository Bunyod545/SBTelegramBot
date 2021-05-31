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
        public ITelegramBotCommand GetInternalCommand(string name)
        {
            var info = Infos.FirstOrDefault(s => s.CommandType == TelegramBotCommandType.InternalCommand &&
                                                 s.CommandName != null &&
                                                 s.CommandName.IsEqualName(name));

            return GetCommandInstance(info);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="clrName"></param>
        /// <returns></returns>
        public ITelegramBotCommand GetInternalCommandByClrName(string clrName)
        {
            var info = Infos.FirstOrDefault(s => s.CommandType == TelegramBotCommandType.InternalCommand &&
                                                 s.CommandClrName == clrName);

            return GetCommandInstance(info);
        }
    }
}
