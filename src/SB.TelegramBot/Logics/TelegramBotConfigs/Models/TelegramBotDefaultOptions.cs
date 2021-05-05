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
            ServiceActivator = new TelegramBotServiceActivator();
        }
    }
}
