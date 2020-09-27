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
    public static class TelegramBotMessageHandlerManager
    {
        /// <summary>
        /// 
        /// </summary>
        private readonly static List<Type> HandlerTypes;

        /// <summary>
        /// 
        /// </summary>
        static TelegramBotMessageHandlerManager()
        {
            HandlerTypes = new List<Type>();
            AddHandler<BackCommandMessageHandler>();
            AddHandler<HighestCommandMessageHandler>();
            AddHandler<PriorityCommandHandler>();
            AddHandler<LowPriorityCommandMessageHandler>();
            AddHandler<CurrentCommandMessageHandler>();
            AddHandler<PublicCommandMessageHandler>();
            AddHandler<UnknownMessageHandler>();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="THandler"></typeparam>
        public static void AddHandler<THandler>() where THandler : ICommandMessageHandler
        {
            HandlerTypes.Add(typeof(THandler));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="THandler"></typeparam>
        /// <typeparam name="TBeforeHandler"></typeparam>
        public static void AddBeforeHandler<THandler, TBeforeHandler>() 
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
        public static void AddAfterHandler<THandler, TAfterHandler>()
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
        public static void RemoveHandler<THandler>() where THandler : ICommandMessageHandler
        {
            HandlerTypes.RemoveAll(r => r == typeof(THandler));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="message"></param>
        public static void Handle(Message message)
        {
            TelegramBotServicesContainer.RequestBegin();
            InternalHandle(message);
            TelegramBotServicesContainer.RequestEnd();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="message"></param>
        private static void InternalHandle(Message message)
        {
            TelegramBotMessageManager.Message.Value = message;
            var userService = TelegramBotServicesContainer.GetService<ITelegramBotUserService>();
            var currentUser = userService.GetCurrentUserInfo();

            if (currentUser == null)
                currentUser = userService.RegisterUser();

            TelegramBotLanguageHelper.InitializeCulture(currentUser.Language);

            var context = new MessageContext();
            context.Message = message;
            context.UserService = userService;
            context.User = currentUser;

            var handlers = GetMessageHandlers();
            for (int index = 0; index < handlers.Count; index++)
            {
                var handler = handlers[index];
                if (index < handlers.Count)
                    context.NextHandler = handlers[index + 1];

                handler.Handle(context);
                if (!context.IsCanNextHandler)
                    break;
            }
        } 

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static List<ICommandMessageHandler> GetMessageHandlers()
        {
            return HandlerTypes.Select(s => (ICommandMessageHandler)TelegramBotServicesContainer.CreateWithServices(s)).ToList();
        }
    }
}
