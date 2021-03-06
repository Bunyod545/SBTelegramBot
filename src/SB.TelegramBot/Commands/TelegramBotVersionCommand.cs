﻿namespace SB.TelegramBot.Commands
{
    /// <summary>
    /// 
    /// </summary>
    [TelegramBotCommandName("/version")]
    public class TelegramBotVersionCommand : TelegramBotPublicCommand
    {
        /// <summary>
        /// 
        /// </summary>
        public override void Execute()
        {
            var version = TelegramBotApplication.Version;
            MessageService.SendMessage($"TelegramBot Application version: {version}");
        }
    }
}