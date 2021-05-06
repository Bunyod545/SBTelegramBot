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
        /// <param name="servicesProvider"></param>
        void Initialize(ITelegramBotServicesProvider servicesProvider);

        /// <summary>
        /// 
        /// </summary>
        void Execute();
    }
}
