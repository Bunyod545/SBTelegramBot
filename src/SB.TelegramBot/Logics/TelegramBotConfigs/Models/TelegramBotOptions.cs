using SB.TelegramBot.Logics.TelegramBotDIContainers;

namespace SB.TelegramBot.Logics.TelegramBotConfigs
{
    /// <summary>
    /// 
    /// </summary>
    public class TelegramBotOptions
    {
        /// <summary>
        /// 
        /// </summary>
        public ITelegramBotServicesContainer Container { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public ITelegramBotServicesProvider ServicesProvider { get; set; }
    }
}
