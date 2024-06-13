using SB.TelegramBot.Logics.TelegramBotCommands.Factories;
using SB.TelegramBot.Logics.TelegramBotCommands.Factories.Models;
using SB.TelegramBot.Logics.TelegramBotDIContainers;
using SB.TelegramBot.Repositories.UsersRepositories;

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
        protected readonly ITelegramBotMessageService MessageService;

        /// <summary>
        /// 
        /// </summary>
        protected readonly ITelegramBotUserRepository UserRepository;

        /// <summary>
        /// 
        /// </summary>
        protected long ChatId => MessageService.ChatId;

        /// <summary>
        /// 
        /// </summary>
        protected ITelegramBotServicesProvider TelegramBotServicesProvider { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        protected ITelegramBotCommandFactory TelegramBotCommandFactory { get; private set; }

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
        /// <param name="servicesProvider"></param>
        public TelegramBotCommandService(
            ITelegramBotCurrentCommand currentCommand, 
            ITelegramBotServicesProvider servicesProvider, 
            ITelegramBotUserRepository userRepository)
        {
            Command = currentCommand.GetCurrentCommand();
            TelegramBotServicesProvider = servicesProvider;
            TelegramBotCommandFactory = servicesProvider.GetService<ITelegramBotCommandFactory>();

            Info = TelegramBotCommandFactory.GetCommandInfo(Command.GetType());
            MessageService = TelegramBotServicesProvider.GetService<ITelegramBotMessageService>();
            UserRepository = userRepository;
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
            var command = TelegramBotServicesProvider.CreateWithServices<T>();
            command.Initialize(TelegramBotServicesProvider);

            return command;
        }
    }
}
