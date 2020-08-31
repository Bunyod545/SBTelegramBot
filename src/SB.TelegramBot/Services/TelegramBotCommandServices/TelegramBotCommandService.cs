using SB.TelegramBot.Logics.TelegramBotCommands.Factories;
using SB.TelegramBot.Logics.TelegramBotCommands.Factories.Models;
using SB.TelegramBot.Logics.TelegramBotDIContainers;

namespace SB.TelegramBot.Services
{
    /// <summary>
    /// 
    /// </summary>
    public class TelegramBotCommandService : ITelegramBotCommandService
    {
        /// <summary>
        /// 
        /// </summary>
        public ITelegramBotCommand Command { get; }

        /// <summary>
        /// 
        /// </summary>
        public TelegramBotCommandInfo Info { get; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="command"></param>
        public TelegramBotCommandService(ITelegramBotCommand command)
        {
            Command = command;
            Info = TelegramBotCommandFactory.GetCommand(command.GetType());
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public long GetCommandId()
        {
            return Info.CommandId;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public TelegramBotCommandType GetCommandType()
        {
            return Info.CommandType;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public ITelegramBotCommandName GetCommandName()
        {
            return Info.CommandName;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public void Execute<T>() where T : ITelegramBotCommand
        {
            var command = CreateCommand<T>();
            command.Execute();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public T CreateCommand<T>() where T : ITelegramBotCommand
        {
            return TelegramBotServicesContainer.CreateWithServices<T>();
        }
    }
}
