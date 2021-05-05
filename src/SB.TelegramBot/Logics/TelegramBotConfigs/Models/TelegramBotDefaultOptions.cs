using SB.TelegramBot.Logics.TelegramBotDIContainers;

namespace SB.TelegramBot.Logics.TelegramBotConfigs
{
    /// <summary>
    /// 
    /// </summary>
    public class TelegramBotDefaultOptions : TelegramBotOptions
    {
        /// <summary>
        /// 
        /// </summary>
        public TelegramBotDefaultOptions()
        {
            var container = new TelegramBotServicesContainer();

            Container = container;
            ServicesProvider = new TelegramBotServicesProvider(container);
        }
    }
}
