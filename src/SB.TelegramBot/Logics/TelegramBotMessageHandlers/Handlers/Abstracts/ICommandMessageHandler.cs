using SB.TelegramBot.Logics.TelegramBotDIContainers;

namespace SB.TelegramBot
{
    /// <summary>
    /// 
    /// </summary>
    public interface ICommandMessageHandler
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="container"></param>
        void Initialize(ITelegramBotServicesContainer container);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="context"></param>
        void Handle(MessageContext context);
    }
}
