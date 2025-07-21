using SB.TelegramBot.Logics.TelegramBotClients;
using SB.TelegramBot.Logics.TelegramBotDIContainers;
using SB.TelegramBot.Services;
using Telegram.Bot;
using Telegram.Bot.Types;

namespace SB.TelegramBot
{
    /// <summary>
    /// 
    /// </summary>
    public abstract partial class TelegramBotBaseCommand : ITelegramBotCommand
    {
        /// <summary>
        /// 
        /// </summary>
        public TelegramBotClient Client { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        public Update Update { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        public ITelegramBotUserService UserService { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        public ITelegramBotCommandService CommandService { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        public ITelegramBotMessageService MessageService { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        public ITelegramBotPollService PollService { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        public ITelegramBotServicesProvider ServicesProvider { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        protected TelegramBotBaseCommand()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="servicesProvider"></param>
        public virtual void Initialize(ITelegramBotServicesProvider servicesProvider)
        {
            ServicesProvider = servicesProvider;
            Client = ServicesProvider.GetService<ITelegramBotClientManager>().Client;
            UserService = ServicesProvider.GetService<ITelegramBotUserService>();
            MessageService = ServicesProvider.GetService<ITelegramBotMessageService>();
            CommandService = ServicesProvider.GetService<ITelegramBotCommandService>();
            PollService = ServicesProvider.GetService<ITelegramBotPollService>();
            Update = ServicesProvider.GetService<ITelegramBotCurrentUpdate>().GetCurrentUpdate();
        }

        public virtual void ExecuteCommand(ITelegramBotCommand command)
        {
            var currentCommand = ServicesProvider.GetService<ITelegramBotCurrentCommand>();
            currentCommand?.SetCurrentCommand(command);
            
            command?.Initialize(ServicesProvider);
            command?.Execute();
        }

        /// <summary>
        /// 
        /// </summary>
        public abstract void Execute();
    }
}
