using SB.TelegramBot.Logics.TelegramBotCommands.Factories.Models;
using SB.TelegramBot.Logics.TelegramBotDIContainers;
using SB.TelegramBot.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace SB.TelegramBot.Logics.TelegramBotCommands.Factories
{
    /// <summary>
    /// 
    /// </summary>
    public static partial class TelegramBotCommandFactory
    {
        /// <summary>
        /// 
        /// </summary>
        private static List<TelegramBotCommandInfo> Infos;

        /// <summary>
        /// 
        /// </summary>
        public static void Initialize()
        {
            Infos = new List<TelegramBotCommandInfo>();

            var assemblies = AppDomain.CurrentDomain.GetAssemblies();
            var types = assemblies.SelectMany(s => s.GetTypes());

            var interfaceType = typeof(ITelegramBotCommand);
            var commandTypes = types.Where(w => interfaceType.IsAssignableFrom(w)).ToList();

            commandTypes.ForEach(InitializeInfo);
            Infos.ForEach(InitializeLowCommands);
            Infos.ForEach(InitializeHighestCommand);

            var initializer = TelegramBotServicesContainer.GetService<ITelegramBotCommandFactoryInitializer>();
            initializer.Initialize(new List<TelegramBotCommandInfo>(Infos));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="commandClrType"></param>
        private static void InitializeInfo(Type commandClrType)
        {
            if (commandClrType.IsAbstract || commandClrType.IsInterface)
                return;

            var attr = commandClrType.GetCustomAttribute<TelegramBotCommandAttribute>();
            if (attr == null)
                return;

            var info = new TelegramBotCommandInfo();
            info.ClrType = commandClrType;
            info.CommandClrName = commandClrType.Name;
            info.CommandType = attr.Type;

            Infos.Add(info);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="info"></param>
        private static void InitializeHighestCommand(TelegramBotCommandInfo info)
        {
            var attrs = info.ClrType.GetCustomAttribute<TelegramBotHighestCommandAttribute>();
            if (attrs == null)
                return;

            info.IsHighestCommand = true;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="info"></param>
        private static void InitializeLowCommands(TelegramBotCommandInfo info)
        {
            var attrs = info.ClrType.GetCustomAttributes<TelegramBotLowCommandAttribute>();
            if (attrs == null)
                return;

            var lowCommands = attrs.Select(s => s.LowCommand).ToList();
            info.LowCommands = Infos.Where(w => lowCommands.Contains(w.ClrType)).ToList();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public static void IgnoreCommand<T>() where T : ITelegramBotCommand
        {
            Infos.RemoveAll(f => f.ClrType == typeof(T));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static ITelegramBotCommand GetCommandInstance(TelegramBotCommandInfo info)
        {
            if (info == null)
                return null;

            var activator = TelegramBotServicesContainer.GetService<ITelegramBotCommandActivator>();
            return activator.ActivateCommand(info.ClrType);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static List<TelegramBotCommandInfo> GetCommands()
        {
            return new List<TelegramBotCommandInfo>(Infos);
        }
    }
}
