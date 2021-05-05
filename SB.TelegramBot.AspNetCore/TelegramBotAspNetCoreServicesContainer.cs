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
        private IServiceCollection _serviceCollection;

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
            _serviceCollection.AddScoped<TService, TImplementation>();
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
        /// <param name="baseType"></param>
        /// <param name="implementType"></param>
        public void AddTransient(Type baseType, Type implementType)
        {
            _serviceCollection.AddSingleton(baseType, implementType);
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
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public T CreateWithServices<T>()
        {
            return (T)CreateWithServices(typeof(T));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public object CreateWithServices(Type type)
        {
            var ctors = type.GetConstructors();
            if (ctors.Length == 0)
                throw new Exception($"Cannot find any public constructor for {type}");

            if (ctors.Length > 1)
                throw new Exception($"More public constructors for {type}");

            var ctor = ctors.FirstOrDefault();
            var ctorParamsInfos = ctor.GetParameters();

            var ctorParams = new object[ctorParamsInfos.Length];
            for (int index = 0; index < ctorParamsInfos.Length; index++)
            {
                var ctorParamInfo = ctorParamsInfos[index];
                ctorParams[index] = GetService(ctorParamInfo.ParameterType);
            }

            return Activator.CreateInstance(type, ctorParams);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TInterface"></typeparam>
        /// <returns></returns>
        public TInterface GetService<TInterface>()
        {
           return _serviceCollection.
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public object GetService(Type type)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        public void Initialize()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public bool IsRegistered<T>()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="serviceType"></param>
        /// <returns></returns>
        public bool IsRegistered(Type serviceType)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        public void RequestBegin()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        public void RequestEnd()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
