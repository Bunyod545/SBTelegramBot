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
    public partial class TelegramBotCommandFactory : ITelegramBotCommandFactory
    {
        /// <summary>
        /// 
        /// </summary>
        private List<TelegramBotCommandInfo> Infos;

        /// <summary>
        /// 
        /// </summary>
        public ITelegramBotServicesProvider TelegramBotServicesProvider { get; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="servicesProvider"></param>
        public TelegramBotCommandFactory(ITelegramBotServicesProvider servicesProvider)
        {
            TelegramBotServicesProvider = servicesProvider;
        }

        /// <summary>
        /// 
        /// </summary>
        public void Initialize()
        {
            Infos = new List<TelegramBotCommandInfo>();

            var assemblies = AppDomain.CurrentDomain.GetAssemblies();
            var types = assemblies.SelectMany(s => s.GetTypes());

            var interfaceType = typeof(ITelegramBotCommand);
            var commandTypes = types.Where(w => interfaceType.IsAssignableFrom(w)).ToList();

            commandTypes.ForEach(InitializeInfo);
            Infos.ForEach(InitializeLowCommands);
            Infos.ForEach(InitializeNearCommands);
            Infos.ForEach(InitializeHighestCommand);

            var initializer = TelegramBotServicesProvider.GetService<ITelegramBotCommandFactoryInitializer>();
            initializer.Initialize(new List<TelegramBotCommandInfo>(Infos));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="commandClrType"></param>
        private void InitializeInfo(Type commandClrType)
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
        private void InitializeHighestCommand(TelegramBotCommandInfo info)
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
        private void InitializeLowCommands(TelegramBotCommandInfo info)
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
        /// <param name="info"></param>
        private void InitializeNearCommands(TelegramBotCommandInfo info)
        {
            var attrs = info.ClrType.GetCustomAttributes<TelegramBotNearCommandAttribute>();
            if (attrs == null)
                return;

            var nearCommands = attrs.Select(s => s.NearCommandType).ToList();
            info.NearCommands = Infos.Where(w => nearCommands.Contains(w.ClrType)).ToList();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public void IgnoreCommand<T>() where T : ITelegramBotCommand
        {
            Infos.RemoveAll(f => f.ClrType == typeof(T));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public ITelegramBotCommand GetCommandInstance(TelegramBotCommandInfo info)
        {
            if (info == null)
                return null;

            var activator = TelegramBotServicesProvider.GetService<ITelegramBotCommandActivator>();
            var command = activator.ActivateCommand(info.ClrType);
            command.Initialize(TelegramBotServicesProvider);

            return command;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<TelegramBotCommandInfo> GetCommands()
        {
            return new List<TelegramBotCommandInfo>(Infos);
        }
    }
}
