using SB.TelegramBot.Logics.TelegramBotDIContainers;
using System;

namespace SB.TelegramBot.Services
{
    /// <summary>
    /// 
    /// </summary>
    public class TelegramBotCommandActivator : ITelegramBotCommandActivator
    {
        /// <summary>
        /// 
        /// </summary>
        protected ITelegramBotServicesProvider TelegramBotServicesContainer { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="telegramBotServicesContainer"></param>
        public TelegramBotCommandActivator(ITelegramBotServicesProvider telegramBotServicesContainer)
        {
            TelegramBotServicesContainer = telegramBotServicesContainer;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="commandClrType"></param>
        /// <returns></returns>
        public virtual ITelegramBotCommand ActivateCommand(Type commandClrType)
        {
            return TelegramBotServicesContainer.CreateWithServices(commandClrType) as ITelegramBotCommand;
        }
    }
}
