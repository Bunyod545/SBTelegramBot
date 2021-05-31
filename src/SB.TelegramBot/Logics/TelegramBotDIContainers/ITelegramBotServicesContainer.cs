using System;

namespace SB.TelegramBot.Logics.TelegramBotDIContainers
{
    /// <summary>
    /// 
    /// </summary>
    public interface ITelegramBotServicesContainer : IDisposable
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="baseType"></param>
        /// <param name="implementType"></param>
        void AddScoped(Type baseType, Type implementType);

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TService"></typeparam>
        /// <typeparam name="TImplementation"></typeparam>
        void AddScoped<TService, TImplementation>()
           where TService : class
           where TImplementation : class, TService;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="baseType"></param>
        /// <param name="implementType"></param>
        void AddSingleton(Type baseType, Type implementType);

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TService"></typeparam>
        /// <param name="implementationFactory"></param>
        void AddSingleton<TService>(Func<TService> implementationFactory) where TService : class;

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TService"></typeparam>
        /// <typeparam name="TImplementation"></typeparam>
        void AddSingleton<TService, TImplementation>()
           where TService : class
           where TImplementation : class, TService;

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        void AddSingleton<T>(T data) where T: class;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="baseType"></param>
        /// <param name="implementType"></param>
        void AddTransient(Type baseType, Type implementType);

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TService"></typeparam>
        /// <typeparam name="TImplementation"></typeparam>
        void AddTransient<TService, TImplementation>()
           where TService : class
           where TImplementation : class, TService;

        /// <summary>
        /// 
        /// </summary>
        void Initialize();
    }
}
