using SB.TelegramBot.Logics.TelegramBotCommands.Factories;
using SB.TelegramBot.Logics.TelegramBotCommands.Factories.Models;
using SB.TelegramBot.Logics.TelegramBotDIContainers;

namespace SB.TelegramBot.Services
{
    /// <summary>
    /// 
    /// </summary>
    public partial class TelegramBotCommandService : ITelegramBotCommandService
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
        protected readonly ITelegramBotMessageService MessageService;

        /// <summary>
        /// 
        /// </summary>
        protected long ChatId => MessageService.ChatId;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="command"></param>
        public TelegramBotCommandService(ITelegramBotCommand command)
        {
            Command = command;
            Info = TelegramBotCommandFactory.GetCommandInfo(command.GetType());
            MessageService = TelegramBotServicesContainer.GetService<ITelegramBotMessageService>();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public virtual long GetCommandId()
        {
            return Info.CommandId;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public virtual TelegramBotCommandType GetCommandType()
        {
            return Info.CommandType;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public virtual ITelegramBotCommandName GetCommandName()
        {
            return Info.CommandName;
        }

        /// <summary>
        /// 
        /// </summary>
        public virtual void ClearCacheCommands()
        {
            ClearCacheCommands(ChatId);
        }

        /// <summary>
        /// 
        /// </summary>
        public virtual void ClearCacheCommands(long chatId)
        {
            ClearCurrentCommand(chatId);
            ClearBackCommand(chatId);
            ClearBackCommandHandler(chatId);
            ClearPriorityCommands(chatId);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public virtual void Execute<T>() where T : ITelegramBotCommand
        {
            var command = CreateCommand<T>();
            command.Execute();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public virtual T CreateCommand<T>() where T : ITelegramBotCommand
        {
            return TelegramBotServicesContainer.CreateWithServices<T>();
        }
    }
}
