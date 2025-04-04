﻿using SB.TelegramBot.Databases;
using SB.TelegramBot.Databases.Tables;
using SB.TelegramBot.Logics.TelegramBotCommands.Factories.Models;
using SB.TelegramBot.Logics.TelegramBotDIContainers;
using SB.TelegramBot.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace SB.TelegramBot.Services
{
    /// <summary>
    /// 
    /// </summary>
    public class TelegramBotCommandFactoryInitializer : ITelegramBotCommandFactoryInitializer
    {
        /// <summary>
        /// 
        /// </summary>
        private List<TelegramBotDbCommand> _dbCommands;

        /// <summary>
        /// 
        /// </summary>
        private readonly ITelegramDbCommandRepository _dbCommandRepository;

        /// <summary>
        /// 
        /// </summary>
        protected ITelegramBotServicesProvider TelegramBotServicesContainer { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        public TelegramBotCommandFactoryInitializer(ITelegramBotServicesProvider telegramBotServicesContainer)
        {
            TelegramBotServicesContainer = telegramBotServicesContainer;
            _dbCommandRepository = telegramBotServicesContainer.GetService<ITelegramDbCommandRepository>();
            _dbCommands = _dbCommandRepository.FindAll();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="infos"></param>
        public virtual void Initialize(List<TelegramBotCommandInfo> infos)
        {
            infos.ForEach(InitializeInfo);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="info"></param>
        protected virtual void InitializeInfo(TelegramBotCommandInfo info)
        {
            InitializeIdentifier(info);
            InitializeName(info);
            InitializeRole(info);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="info"></param>
        protected virtual void InitializeIdentifier(TelegramBotCommandInfo info)
        {
            var dbCommand = _dbCommands.FirstOrDefault(f => f.ClrName == info.ClrType.Name);
            if (dbCommand == null)
            {
                dbCommand = new TelegramBotDbCommand();
                dbCommand.ClrName = info.ClrType.Name;
                _dbCommandRepository.Insert(dbCommand);
            }

            info.CommandId = dbCommand.Id;
        }

        /// <summary>
        /// 
        /// </summary>
        protected virtual void InitializeName(TelegramBotCommandInfo info)
        {
            if (InitializeNameWithType(info))
                return;

            InitializeNameWithService(info);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        protected virtual bool InitializeNameWithType(TelegramBotCommandInfo info)
        {
            var attrs = info.ClrType.GetCustomAttributes(typeof(TelegramBotCommandNameAttribute), false);
            if (attrs.Length != 1)
                return false;

            var attr = (TelegramBotCommandNameAttribute)attrs.FirstOrDefault();
            if (attr.CommandNameType == null)
                return false;

            var commandName = TelegramBotServicesContainer.CreateWithServices(attr.CommandNameType) as ITelegramBotCommandName;
            if (commandName == null)
                return false;

            info.CommandName = commandName;
            commandName.Initialize(info);
            return true;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        protected virtual void InitializeNameWithService(TelegramBotCommandInfo info)
        {
            var commandName = TelegramBotServicesContainer.GetService<ITelegramBotCommandName>();
            if (commandName == null)
                return;

            info.CommandName = commandName;
            commandName.Initialize(info);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        protected virtual void InitializeRole(TelegramBotCommandInfo info)
        {
            var commandrole = TelegramBotServicesContainer.GetService<ITelegramBotCommandRole>();
            if (commandrole == null)
                return;

            info.CommandRole = commandrole;
            commandrole.Initialize(info);
        }
    }
}
