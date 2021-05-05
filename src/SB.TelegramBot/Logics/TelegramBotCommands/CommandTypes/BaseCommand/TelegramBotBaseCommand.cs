using SB.TelegramBot.Logics.TelegramBotClients;
using SB.TelegramBot.Logics.TelegramBotCommands.Factories;
using SB.TelegramBot.Logics.TelegramBotDIContainers;
using SB.TelegramBot.Services;
using Telegram.Bot;

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
        public ITelegramBotServicesContainer ServicesContainer { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        protected TelegramBotBaseCommand()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="container"></param>
        public virtual void Initialize(ITelegramBotServicesContainer container)
        {
            ServicesContainer = container;
            Client = ServicesContainer.GetService<ITelegramBotClientManager>().Client;
            UserService = ServicesContainer.GetService<ITelegramBotUserService>();
            MessageService = ServicesContainer.GetService<ITelegramBotMessageService>();
            CommandService = new TelegramBotCommandService(this, ServicesContainer);
        }

        /// <summary>
        /// 
        /// </summary>
        public abstract void Execute();
    }
}
