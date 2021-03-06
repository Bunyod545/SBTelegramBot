﻿using Telegram.Bot.Args;


namespace SB.TelegramBot.Services
{
    /// <summary>
    /// 
    /// </summary>
    public class TelegramBotMessageHandler : ITelegramBotMessageHandler
    {
        /// <summary>
        /// 
        /// </summary>
        private readonly ITelegramBotMessageHandlerManager _handlerManager;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="handlerManager"></param>
        public TelegramBotMessageHandler(ITelegramBotMessageHandlerManager handlerManager)
        {
            _handlerManager = handlerManager;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public virtual void Handle(object sender, MessageEventArgs e)
        {
            _handlerManager.Handle(e.Message);
        }
    }
}
