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
        /// <param name="commandId"></param>
        /// <returns></returns>
        public static ITelegramBotCommand GetCallbackCommand(long commandId)
        {
            var info = Infos.FirstOrDefault(s => s.CommandType == TelegramBotCommandType.CallbackCommand &&
                                                 s.CommandId == commandId);

            return GetCommandInstance(info);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static ITelegramBotCommand GetCallbackCommand(string name)
        {
            var info = Infos.FirstOrDefault(s => s.CommandType == TelegramBotCommandType.CallbackCommand &&
                                                 s.CommandName != null &&
                                                 s.CommandName.IsEqualName(name));

            return GetCommandInstance(info);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="clrName"></param>
        /// <returns></returns>
        public static ITelegramBotCommand GetCallbackCommandByClrName(string clrName)
        {
            var info = Infos.FirstOrDefault(s => s.CommandType == TelegramBotCommandType.CallbackCommand &&
                                                 s.CommandClrName == clrName);

            return GetCommandInstance(info);
        }
    }
}
