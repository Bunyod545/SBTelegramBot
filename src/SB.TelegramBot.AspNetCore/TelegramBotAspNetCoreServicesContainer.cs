using Microsoft.Extensions.DependencyInjection;
using SB.TelegramBot.Logics.TelegramBotDIContainers;
using System;
using System.Linq;

namespace SB.TelegramBot.AspNetCore
{
    /// <summary>
    /// 
    /// </summary>
    public class TelegramBotAspNetCoreServicesContainer : ITelegramBotServicesContainer
    {
        /// <summary>
        /// 
        /// </summary>
        private readonly IServiceCollection _serviceCollection;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="serviceCollection"></param>
        public TelegramBotAspNetCoreServicesContainer(IServiceCollection serviceCollection)
        {
            _serviceCollection = serviceCollection;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="baseType"></param>
        /// <param name="implementType"></param>
        public void AddScoped(Type baseType, Type implementType)
        {
            _serviceCollection.AddScoped(baseType, implementType);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TService"></typeparam>
        /// <typeparam name="TImplement"></typeparam>
        public void AddScoped<TService, TImplementation>()
           where TService : class
           where TImplementation : class, TService
        {
            _serviceCollection.AddScoped<TService, TImplementation>();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="baseType"></param>
        /// <param name="implementType"></param>
        public void AddSingleton(Type baseType, Type implementType)
        {
            _serviceCollection.AddSingleton(baseType, implementType);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TService"></typeparam>
        /// <typeparam name="TImplementation"></typeparam>
        public void AddSingleton<TService, TImplementation>()
           where TService : class
           where TImplementation : class, TService
        {
            _serviceCollection.AddSingleton<TService, TImplementation>();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="data"></param>
        public void AddSingleton<T>(T data) where T : class
        {
            _serviceCollection.AddSingleton(data);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TService"></typeparam>
        /// <param name="implementationFactory"></param>
        public void AddSingleton<TService>(Func<TService> implementationFactory) where TService : class
        {
            _serviceCollection.AddSingleton(s => implementationFactory());
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="baseType"></param>
        /// <param name="implementType"></param>
        public void AddTransient(Type baseType, Type implementType)
        {
            _serviceCollection.AddTransient(baseType, implementType);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TService"></typeparam>
        /// <typeparam name="TImplementation"></typeparam>
        public void AddTransient<TService, TImplementation>()
           where TService : class
           where TImplementation : class, TService
        {
            _serviceCollection.AddTransient<TService, TImplementation>();
        }

        /// <summary>
        /// 
        /// </summary>
        public void Initialize()
        {

        }

        /// <summary>
        /// 
        /// </summary>
        public void Dispose()
        {

        }
    }
}
