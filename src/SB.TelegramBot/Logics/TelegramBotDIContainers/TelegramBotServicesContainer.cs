using Autofac;
using System;
using System.Linq;
using System.Threading;

namespace SB.TelegramBot.Logics.TelegramBotDIContainers
{
    /// <summary>
    /// 
    /// </summary>
    public static class TelegramBotServicesContainer
    {
        /// <summary>
        /// 
        /// </summary>
        private static ContainerBuilder _containerBuilder;

        /// <summary>
        /// 
        /// </summary>
        private static IContainer _container;

        /// <summary>
        /// 
        /// </summary>
        private static readonly AsyncLocal<ILifetimeScope> Scope = new AsyncLocal<ILifetimeScope>();

        /// <summary>
        /// 
        /// </summary>
        static TelegramBotServicesContainer()
        {
            _containerBuilder = new ContainerBuilder();
        }

        /// <summary>
        /// 
        /// </summary>
        public static void RequestBegin()
        {
            Scope.Value = _container.BeginLifetimeScope();
        }

        /// <summary>
        /// 
        /// </summary>
        public static void RequestEnd()
        {
            if (Scope.Value == null)
                return;

            Scope.Value.Dispose();
            Scope.Value = null;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="baseType"></param>
        /// <param name="implementType"></param>
        public static void AddScoped(Type baseType, Type implementType)
        {
            _containerBuilder.RegisterType(implementType).As(baseType).InstancePerLifetimeScope();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TInterface"></typeparam>
        /// <typeparam name="TImplement"></typeparam>
        public static void AddScoped<TInterface, TImplement>() where TImplement : TInterface
        {
            _containerBuilder.RegisterType<TImplement>().As<TInterface>().InstancePerLifetimeScope();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="baseType"></param>
        /// <param name="implementType"></param>
        public static void AddSingleton(Type baseType, Type implementType)
        {
            _containerBuilder.RegisterType(implementType).As(baseType).SingleInstance();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TInterface"></typeparam>
        /// <typeparam name="TImplement"></typeparam>
        public static void AddSingleton<TInterface, TImplement>() where TImplement : TInterface
        {
            _containerBuilder.RegisterType<TImplement>().As<TInterface>().SingleInstance();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="baseType"></param>
        /// <param name="implementType"></param>
        public static void AddTransient(Type baseType, Type implementType)
        {
            _containerBuilder.RegisterType(implementType).As(baseType).InstancePerDependency();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TInterface"></typeparam>
        /// <typeparam name="TImplement"></typeparam>
        public static void AddTransient<TInterface, TImplement>() where TImplement : TInterface
        {
            _containerBuilder.RegisterType<TImplement>().As<TInterface>().InstancePerDependency();
        }

        /// <summary>
        /// 
        /// </summary>
        public static void Initialize()
        {
            _container = _containerBuilder.Build();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static bool IsRegistered<T>()
        {
            return IsRegistered(typeof(T));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="serviceType"></param>
        /// <returns></returns>
        public static bool IsRegistered(Type serviceType)
        {
            return _container.IsRegistered(serviceType);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TInterface"></typeparam>
        public static TInterface GetService<TInterface>()
        {
            return (TInterface)GetService(typeof(TInterface));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TInterface"></typeparam>
        public static object GetService(Type type)
        {
            if (Scope.Value != null)
                return Scope.Value.Resolve(type);

            return _container.Resolve(type);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public static T CreateWithServices<T>()
        {
            return (T)CreateWithServices(typeof(T));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public static object CreateWithServices(Type type)
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
        public static void Dispose()
        {
            _container.Dispose();
            _containerBuilder = null;
            _container = null;
        }
    }
}
