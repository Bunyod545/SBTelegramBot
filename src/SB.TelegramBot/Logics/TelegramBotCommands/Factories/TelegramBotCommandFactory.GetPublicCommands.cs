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
        public ITelegramBotCommand GetPublicOrInternalCommand(string name)
        {
            var info = Infos.FirstOrDefault(s => (s.CommandType == TelegramBotCommandType.PublicCommand ||
                                                  s.CommandType == TelegramBotCommandType.InternalCommand) &&
                                                  s.CommandName != null &&
                                                  s.CommandName.IsEqualName(name));

            return GetCommandInstance(info);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="clrName"></param>
        /// <returns></returns>
        public ITelegramBotCommand GetPublicOrInternalCommandByClrName(string clrName)
        {
            var info = Infos.FirstOrDefault(s => (s.CommandType == TelegramBotCommandType.PublicCommand ||
                                                  s.CommandType == TelegramBotCommandType.InternalCommand) &&
                                                  s.CommandName != null &&
                                                  s.CommandClrName == clrName);

            return GetCommandInstance(info);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public TelegramBotCommandInfo GetPublicCommandInfo(string name)
        {
            return Infos.FirstOrDefault(s => s.CommandType == TelegramBotCommandType.PublicCommand &&
                                             s.CommandName != null &&
                                             s.CommandName.IsEqualName(name));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="role"></param>
        /// <returns></returns>
        public TelegramBotCommandInfo GetPublicCommandInfo(string name, string role)
        {
            return Infos.FirstOrDefault(s => s.CommandType == TelegramBotCommandType.PublicCommand &&
                                             s.CommandName != null &&
                                             s.CommandName.IsEqualName(name) &&
                                             s.CommandRole != null &&
                                             s.CommandRole.IsEqualRole(role));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public ITelegramBotCommand GetPublicCommand(string name, string role)
        {
            var info = Infos.FirstOrDefault(s => s.CommandType == TelegramBotCommandType.PublicCommand &&
                                                 s.CommandName != null &&
                                                 s.CommandName.IsEqualName(name) &&
                                                 s.CommandRole != null &&
                                                 s.CommandRole.IsEqualRole(role));

            return GetCommandInstance(info);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public ITelegramBotCommand GetPublicCommand(string name)
        {
            var info = Infos.FirstOrDefault(s => s.CommandType == TelegramBotCommandType.PublicCommand &&
                                                 s.CommandName != null &&
                                                 s.CommandName.IsEqualName(name));

            return GetCommandInstance(info);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="clrName"></param>
        /// <returns></returns>
        public ITelegramBotCommand GetPublicCommandByClrName(string clrName)
        {
            var info = Infos.FirstOrDefault(s => s.CommandType == TelegramBotCommandType.PublicCommand &&
                                                 s.CommandClrName == clrName);

            return GetCommandInstance(info);
        }
    }
}
