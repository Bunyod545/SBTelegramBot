using System;

namespace SB.TelegramBot.Logics.TelegramBotDIContainers
{
    /// <summary>
    /// 
    /// </summary>
    public class TelegramBotServiceActivator : ITelegramBotServiceActivator
    {
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TService"></typeparam>
        public TService GetService<TService>()
        {
            return TelegramBotServicesContainer.GetService<TService>();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="serviceType"></typeparam>
        public object GetService(Type serviceType)
        {
            return TelegramBotServicesContainer.GetService(serviceType);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TService"></typeparam>
        /// <returns></returns>
        public TService ActivateWithServices<TService>()
        {
            return TelegramBotServicesContainer.CreateWithServices<TService>();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="serviceType"></param>
        /// <returns></returns>
        public object ActivateWithServices(Type serviceType)
        {
            return TelegramBotServicesContainer.CreateWithServices(serviceType);
        }
    }
}
