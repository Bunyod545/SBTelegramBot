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
        /// <param name="servicesCollection"></param>
        public static void Register(ITelegramBotServicesContainer servicesCollection)
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

            types.ForEach(f => RegisterService(f, servicesCollection));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="type"></param>
        /// <param name="servicesCollection"></param>
        private static void RegisterService(Type type, ITelegramBotServicesContainer servicesCollection)
        {
            var attr = type.GetCustomAttribute<BotServiceAttribute>();

            if (attr.LifeCycle == BotServiceLifeCycle.Scoped)
            {
                RegisterScopedService(type, servicesCollection);
                return;
            }

            if (attr.LifeCycle == BotServiceLifeCycle.Singleton)
            {
                RegisterSingletonService(type, servicesCollection);
                return;
            }

            if (attr.LifeCycle == BotServiceLifeCycle.Transient)
            {
                RegisterTransientService(type, servicesCollection);
                return;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="type"></param>
        /// <param name="servicesCollection"></param>
        private static void RegisterScopedService(Type type, ITelegramBotServicesContainer servicesCollection)
        {
            var interfaces = type.GetInterfaces().ToList();
            var baseType = type.BaseType;

            interfaces.ForEach(f => servicesCollection.AddScoped(f, type));

            if (baseType != typeof(object))
                servicesCollection.AddScoped(baseType, type);

            servicesCollection.AddScoped(type, type);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="type"></param>
        /// <param name="servicesCollection"></param>
        private static void RegisterSingletonService(Type type, ITelegramBotServicesContainer servicesCollection)
        {
            var interfaces = type.GetInterfaces().ToList();
            var baseType = type.BaseType;

            interfaces.ForEach(f => servicesCollection.AddSingleton(f, type));

            if (baseType != typeof(object))
                servicesCollection.AddSingleton(baseType, type);

            servicesCollection.AddSingleton(type, type);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="type"></param>
        /// <param name="servicesCollection"></param>
        private static void RegisterTransientService(Type type, ITelegramBotServicesContainer servicesCollection)
        {
            var interfaces = type.GetInterfaces().ToList();
            var baseType = type.BaseType;

            interfaces.ForEach(f => servicesCollection.AddTransient(f, type));

            if (baseType != typeof(object))
                servicesCollection.AddTransient(baseType, type);

            servicesCollection.AddTransient(type, type);
        }
    }
}
