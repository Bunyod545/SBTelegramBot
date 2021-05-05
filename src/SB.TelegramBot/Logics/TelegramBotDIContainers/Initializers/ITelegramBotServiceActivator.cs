using System;

namespace SB.TelegramBot.Logics.TelegramBotDIContainers
{
    /// <summary>
    /// 
    /// </summary>
    public interface ITelegramBotServiceActivator
    {
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TService"></typeparam>
        TService GetService<TService>();

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="serviceType"></typeparam>
        object GetService(Type serviceType);

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TService"></typeparam>
        TService ActivateWithServices<TService>();

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="serviceType"></typeparam>
        object ActivateWithServices(Type serviceType);
    }
}
