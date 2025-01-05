using Telegram.Bot.Types;

namespace SB.TelegramBot
{
    /// <summary>
    /// 
    /// </summary>
    [TelegramBotCommand(TelegramBotCommandType.PollCommand)]
    public abstract class TelegramBotPollCommand : TelegramBotBaseCommand
    {
        /// <summary>
        /// 
        /// </summary>
        public Poll Poll => Update.Poll;

        /// <summary>
        /// 
        /// </summary>
        public PollAnswer PollAnswer => Update.PollAnswer;
    }
}
