using SB.TelegramBot.Logics.TelegramBotDIContainers;
using System;
using System.Linq;
using System.Reflection;

namespace SB.TelegramBot.Logics.TelegramBotAutoDI
{
    /// <summary>
    /// 
    /// </summary>
    public class TelegramBotAutoDIManager
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="servicesContainer"></param>
        public static void Register(ITelegramBotServicesContainer servicesContainer)
        {
            var assemblies = AppDomain.CurrentDomain.GetAssemblies();

            var types = assemblies
                .SelectMany(s => s.GetTypes())
                .Where(w =>
                       w.IsClass &&
                      !w.IsAbstract &&
                      !w.IsSealed &&
                       w.GetCustomAttribute<BotServiceAttribute>() != null)
                .ToList();

            types.ForEach(f => RegisterService(f, servicesContainer));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="type"></param>
        /// <param name="servicesContainer"></param>
        private static void RegisterService(Type type, ITelegramBotServicesContainer servicesContainer)
        {
            var attr = type.GetCustomAttribute<BotServiceAttribute>();

            if (attr.LifeCycle == BotServiceLifeCycle.Scoped)
            {
                RegisterScopedService(type, servicesContainer);
                return;
            }

            if (attr.LifeCycle == BotServiceLifeCycle.Singleton)
            {
                RegisterSingletonService(type, servicesContainer);
                return;
            }

            if (attr.LifeCycle == BotServiceLifeCycle.Transient)
            {
                RegisterTransientService(type, servicesContainer);
                return;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="type"></param>
        /// <param name="servicesContainer"></param>
        private static void RegisterScopedService(Type type, ITelegramBotServicesContainer servicesContainer)
        {
            var interfaces = type.GetInterfaces().ToList();
            var baseType = type.BaseType;

            interfaces.ForEach(f => servicesContainer.AddScoped(f, type));

            if (baseType != typeof(object))
                servicesContainer.AddScoped(baseType, type);

            servicesContainer.AddScoped(type, type);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="type"></param>
        /// <param name="servicesContainer"></param>
        private static void RegisterSingletonService(Type type, ITelegramBotServicesContainer servicesContainer)
        {
            var interfaces = type.GetInterfaces().ToList();
            var baseType = type.BaseType;

            interfaces.ForEach(f => servicesContainer.AddSingleton(f, type));

            if (baseType != typeof(object))
                servicesContainer.AddSingleton(baseType, type);

            servicesContainer.AddSingleton(type, type);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="type"></param>
        /// <param name="servicesContainer"></param>
        private static void RegisterTransientService(Type type, ITelegramBotServicesContainer servicesContainer)
        {
            var interfaces = type.GetInterfaces().ToList();
            var baseType = type.BaseType;

            interfaces.ForEach(f => servicesContainer.AddTransient(f, type));

            if (baseType != typeof(object))
                servicesContainer.AddTransient(baseType, type);

            servicesContainer.AddTransient(type, type);
        }
    }
}
