using Autofac;
using System;

namespace SB.TelegramBot.Logics.TelegramBotDIContainers
{
    /// <summary>
    /// 
    /// </summary>
    public class TelegramBotServicesContainer : ITelegramBotServicesContainer
    {
        /// <summary>
        /// 
        /// </summary>
        private ContainerBuilder _containerBuilder;

        /// <summary>
        /// 
        /// </summary>
        public IContainer Container;

        /// <summary>
        /// 
        /// </summary>
        public TelegramBotServicesContainer()
        {
            _containerBuilder = new ContainerBuilder();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="baseType"></param>
        /// <param name="implementType"></param>
        public void AddScoped(Type baseType, Type implementType)
        {
            _containerBuilder.RegisterType(implementType).As(baseType).InstancePerLifetimeScope();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TService"></typeparam>
        /// <typeparam name="TImplementation"></typeparam>
        public void AddScoped<TService, TImplementation>()
           where TService : class
           where TImplementation : class, TService
        {
            _containerBuilder.RegisterType<TImplementation>().As<TService>().InstancePerLifetimeScope();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="baseType"></param>
        /// <param name="implementType"></param>
        public void AddSingleton(Type baseType, Type implementType)
        {
            _containerBuilder.RegisterType(implementType).As(baseType).SingleInstance();
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
            _containerBuilder.RegisterType<TImplementation>().As<TService>().SingleInstance();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public void AddSingleton<T>(T data) where T: class
        {
            _containerBuilder.RegisterInstance(data).As<T>().SingleInstance();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="baseType"></param>
        /// <param name="implementType"></param>
        public void AddTransient(Type baseType, Type implementType)
        {
            _containerBuilder.RegisterType(implementType).As(baseType).InstancePerDependency();
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
            _containerBuilder.RegisterType<TImplementation>().As<TService>().InstancePerDependency();
        }

        /// <summary>
        /// 
        /// </summary>
        public void Initialize()
        {
            Container = _containerBuilder.Build();
        }

        /// <summary>
        /// 
        /// </summary>
        public void Dispose()
        {
            Container.Dispose();
            _containerBuilder = null;
            Container = null;
        }
    }
}
