using SB.TelegramBot.Helpers;
using SB.TelegramBot.Logics.TelegramBotDIContainers;
using SB.TelegramBot.Logics.TelegramBotMessages;
using SB.TelegramBot.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using Telegram.Bot.Types;

namespace SB.TelegramBot
{
    /// <summary>
    /// 
    /// </summary>
    public class TelegramBotMessageHandlerManager : ITelegramBotMessageHandlerManager
    {
        /// <summary>
        /// 
        /// </summary>
        private readonly List<Type> HandlerTypes;

        /// <summary>
        /// 
        /// </summary>
        private readonly ITelegramBotServicesProvider servicesContainer;

        /// <summary>
        /// 
        /// </summary>
        public TelegramBotMessageHandlerManager(ITelegramBotServicesProvider servicesContainer)
        {
            HandlerTypes = new List<Type>();
            AddHandler<BackCommandMessageHandler>();
            AddHandler<HighestCommandMessageHandler>();
            AddHandler<PriorityCommandHandler>();
            AddHandler<NearCommandMessageHandler>();
            AddHandler<LowPriorityCommandMessageHandler>();
            AddHandler<CurrentCommandMessageHandler>();
            AddHandler<PublicCommandMessageHandler>();
            AddHandler<UnknownMessageHandler>();
            this.servicesContainer = servicesContainer;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="THandler"></typeparam>
        public void AddHandler<THandler>() where THandler : ICommandMessageHandler
        {
            HandlerTypes.Add(typeof(THandler));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="THandler"></typeparam>
        /// <typeparam name="TBeforeHandler"></typeparam>
        public void AddBeforeHandler<THandler, TBeforeHandler>() 
            where THandler : ICommandMessageHandler
            where TBeforeHandler : ICommandMessageHandler
        {
            var index = HandlerTypes.IndexOf(typeof(TBeforeHandler));
            HandlerTypes.Insert(index, typeof(THandler));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="THandler"></typeparam>
        /// <typeparam name="TAfterHandler"></typeparam>
        public void AddAfterHandler<THandler, TAfterHandler>()
            where THandler : ICommandMessageHandler
            where TAfterHandler : ICommandMessageHandler
        {
            var index = HandlerTypes.IndexOf(typeof(TAfterHandler));
            HandlerTypes.Insert(++index, typeof(THandler));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="THandler"></typeparam>
        public void RemoveHandler<THandler>() where THandler : ICommandMessageHandler
        {
            HandlerTypes.RemoveAll(r => r == typeof(THandler));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="message"></param>
        public void Handle(Message message)
        {
            servicesContainer.RequestBegin();
            InternalHandle(message);
            servicesContainer.RequestEnd();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="message"></param>
        private void InternalHandle(Message message)
        {
            TelegramBotMessageManager.Message.Value = message;
            var userService = servicesContainer.GetService<ITelegramBotUserService>();
            var currentUser = userService.GetCurrentUserInfo();

            if (currentUser == null)
                currentUser = userService.RegisterUser();

            TelegramBotLanguageHelper.InitializeCulture(currentUser.Language);

            var context = new MessageContext();
            context.Message = message;
            context.UserService = userService;
            context.User = currentUser;
            context.UserRole = userService.GetCurrentUserRole();

            var handlers = GetMessageHandlers();
            for (int index = 0; index < handlers.Count; index++)
            {
                var handler = handlers[index];
                if (index < handlers.Count - 1)
                    context.NextHandler = handlers[index + 1];

                handler.Initialize(servicesContainer);
                handler.Handle(context);
                if (!context.IsCanExecuteNextHandler)
                    break;
            }
        } 

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<ICommandMessageHandler> GetMessageHandlers()
        {
            return HandlerTypes.Select(s => (ICommandMessageHandler)servicesContainer.CreateWithServices(s)).ToList();
        }
    }
}
