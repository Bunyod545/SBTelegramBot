using System;

namespace SB.TelegramBot.Logics.TelegramBotDIContainers
{
    /// <summary>
    /// 
    /// </summary>
    public interface ITelegramBotServicesProvider : IDisposable
    {
        /// <summary>
        /// 
        /// </summary>
        void RequestBegin();

        /// <summary>
        /// 
        /// </summary>
        void RequestEnd();

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TService"></typeparam>
        /// <returns></returns>
        TService GetService<TService>();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        object GetService(Type type);

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        T CreateWithServices<T>();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        object CreateWithServices(Type type);
    }
}
