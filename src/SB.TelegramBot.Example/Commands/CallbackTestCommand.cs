using System;

namespace SB.TelegramBot.Example.Commands
{
    /// <summary>
    /// 
    /// </summary>
    public class CallbackTestCommand : TelegramBotCallbackCommand
    {
        /// <summary>
        /// 
        /// </summary>
        public override void Execute()
        {
            SendAnswerText("Callback handler command is work!");
        }
    }
}
