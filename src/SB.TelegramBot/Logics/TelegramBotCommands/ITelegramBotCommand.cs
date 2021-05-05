using SB.TelegramBot.Logics.TelegramBotDIContainers;

namespace SB.TelegramBot
{
    /// <summary>
    /// 
    /// </summary>
    public interface ITelegramBotCommand
    {
        /// <summary>
        /// 
        /// </summary>
        void Initialize(ITelegramBotServicesContainer container);

        /// <summary>
        /// 
        /// </summary>
        void Execute();
    }
}
