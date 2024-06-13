using SB.TelegramBot.Logics.TelegramBotDIContainers;

namespace SB.TelegramBot.Services
{
    /// <summary>
    /// 
    /// </summary>
    public class TelegramBotCurrentCommand : ITelegramBotCurrentCommand
    {
        /// <summary>
        /// 
        /// </summary>
        protected ITelegramBotServicesProvider TelegramBotServicesContainer { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        protected ITelegramBotCommand TelegramBotCommand { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="telegramBotServicesContainer"></param>
        public TelegramBotCurrentCommand(ITelegramBotServicesProvider telegramBotServicesContainer)
        {
            TelegramBotServicesContainer = telegramBotServicesContainer;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public ITelegramBotCommand GetCurrentCommand()
        {
            return TelegramBotCommand;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="currentCommand"></param>
        public void SetCurrentCommand(ITelegramBotCommand currentCommand)
        {
            TelegramBotCommand = currentCommand;
        }
    }
}
