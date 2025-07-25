﻿using SB.TelegramBot.Logics.TelegramBotCommands.Factories;
using SB.TelegramBot.Logics.TelegramBotDIContainers;
using SB.TelegramBot.Services;
using System;

namespace SB.TelegramBot
{
    /// <summary>
    /// 
    /// </summary>
    public abstract class BaseCommandMessageHandler : ICommandMessageHandler
    {
        /// <summary>
        /// 
        /// </summary>
        protected ITelegramBotCommandFactory TelegramBotCommandFactory { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        protected ITelegramBotServicesProvider ServicesProvider { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="servicesProvider"></param>
        public virtual void Initialize(ITelegramBotServicesProvider servicesProvider)
        {
            ServicesProvider = servicesProvider;
            TelegramBotCommandFactory = servicesProvider.GetService<ITelegramBotCommandFactory>();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="context"></param>
        public abstract void Handle(MessageContext context);
     
        /// <summary>
        /// 
        /// </summary>
        protected virtual void ExecuteCommand(MessageContext messageContext, ITelegramBotCommand command)
        {
            try
            {
                TryExecuteCommand(messageContext, command);
            }
            catch (Exception ex)
            {
                CatchExecuteCommand(messageContext, command, ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="messageContext"></param>
        /// <param name="command"></param>
        protected virtual void TryExecuteCommand(MessageContext messageContext, ITelegramBotCommand command)
        {
            PrePostExecute(messageContext, command);
            command?.Execute();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="messageContext"></param>
        /// <param name="command"></param>
        protected virtual void PrePostExecute(MessageContext messageContext, ITelegramBotCommand command)
        {
            messageContext.IsCanExecuteNextHandler = false;
            messageContext.HandlerCommand = command;

            var currentCommand = ServicesProvider.GetService<ITelegramBotCurrentCommand>();
            currentCommand?.SetCurrentCommand(command);

            command?.Initialize(ServicesProvider);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="messageContext"></param>
        /// <param name="ex"></param>
        protected virtual void CatchExecuteCommand(MessageContext messageContext, ITelegramBotCommand command, Exception ex)
        {
            if (command is ICommandMessageExceptionHandler exceptionHandler)
                exceptionHandler.HandleExecuteException(messageContext, ex);

            var handlerService = ServicesProvider.GetService<ICommandMessageExceptionHandler>();
            handlerService?.HandleExecuteException(messageContext, ex);
        }
    }
}
