using Microsoft.Extensions.DependencyInjection;
using SB.TelegramBot.Logics.TelegramBotDIContainers;
using System;
using System.Linq;
using System.Threading;

namespace SB.TelegramBot.AspNetCore
{
    /// <summary>
    /// 
    /// </summary>
    public class TelegramBotAspNetCoreServicesProvider : ITelegramBotServicesProvider
    {
        /// <summary>
        /// 
        /// </summary>
        private static readonly AsyncLocal<IServiceScope> Scope = new AsyncLocal<IServiceScope>();

        /// <summary>
        /// 
        /// </summary>
        public IServiceProvider ServiceProvider { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public TelegramBotAspNetCoreServicesProvider()
        {

        }

        /// <summary>
        /// 
        /// </summary>
        public void RequestBegin()
        {
            var scopeFactory = ServiceProvider.GetRequiredService<IServiceScopeFactory>();
            Scope.Value = scopeFactory.CreateScope();
        }

        /// <summary>
        /// 
        /// </summary>
        public void RequestEnd()
        {
            if (Scope.Value == null)
                return;

            Scope.Value.Dispose();
            Scope.Value = null;
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
        public void Dispose()
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TService"></typeparam>
        /// <returns></returns>
        public TService GetService<TService>()
        {
            return (TService)GetService(typeof(TService));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public object GetService(Type type)
        {
            if (Scope.Value != null)
                return Scope.Value.ServiceProvider.GetService(type);

            return ServiceProvider.GetService(type);
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
    }
}
