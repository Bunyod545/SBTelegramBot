using SB.TelegramBot.Logics.TelegramBotDIContainers;
using SB.TelegramBot.Services;

namespace SB.TelegramBot
{
    /// <summary>
    /// 
    /// </summary>
    public class UnknownMessageHandler : ICommandMessageHandler
    {
        /// <summary>
        /// 
        /// </summary>
        protected ITelegramBotServicesProvider TelegramBotServicesContainer { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="container"></param>
        public void Initialize(ITelegramBotServicesProvider container)
        {
            TelegramBotServicesContainer = container;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="context"></param>
        public void Handle(MessageContext context)
        {
            var unknownMessageService = TelegramBotServicesContainer.GetService<ITelegramBotUnknownMessageService>();

            unknownMessageService.Handle();
            context.IsCanExecuteNextHandler = false;
        }
    }
}
