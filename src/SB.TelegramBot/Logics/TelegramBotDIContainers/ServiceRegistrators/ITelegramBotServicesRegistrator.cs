using SB.TelegramBot.Logics.TelegramBotConfigs;

namespace SB.TelegramBot.Logics.TelegramBotDIContainers
{
    /// <summary>
    /// 
    /// </summary>
    public interface ITelegramBotServicesRegistrator
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="servicesContainer"></param>
        /// <param name="options"></param>
        void Register(ITelegramBotServicesContainer servicesContainer, TelegramBotOptions options);
    }
}
