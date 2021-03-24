using System;

namespace SB.TelegramBot.Logics.TelegramBotDIContainers
{
    /// <summary>
    /// 
    /// </summary>
    public interface ITelegramBotServicesCollection
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="baseType"></param>
        /// <param name="serviceType"></param>
        void AddScoped(Type baseType, Type serviceType);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="baseType"></param>
        /// <param name="serviceType"></param>
        void AddTransient(Type baseType, Type serviceType);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="baseType"></param>
        /// <param name="serviceType"></param>
        void AddSingleton(Type baseType, Type serviceType);

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TInterface"></typeparam>
        /// <typeparam name="TImplement"></typeparam>
        void AddScoped<TInterface, TImplement>() where TImplement : TInterface;

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TInterface"></typeparam>
        /// <typeparam name="TImplement"></typeparam>
        void AddSingleton<TInterface, TImplement>() where TImplement : TInterface;

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TInterface"></typeparam>
        /// <typeparam name="TImplement"></typeparam>
        void AddTransient<TInterface, TImplement>() where TImplement : TInterface;

        /// <summary>
        /// 
        /// </summary>
        void Initialize();

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TInterface"></typeparam>
        TInterface GetService<TInterface>();

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TInterface"></typeparam>
        object GetService(Type type);
    }
}
