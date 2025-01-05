namespace SB.TelegramBot.Services
{
    /// <summary>
    /// 
    /// </summary>
    public class TelegramBotCurrentCommand : ITelegramBotCurrentCommand
    {
        /// <summary>
        /// 
        /// </summary>
        protected ITelegramBotCommand TelegramBotCommand { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public ITelegramBotCommand GetCurrentCommand()
        {
            return TelegramBotCommand;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="currentCommand"></param>
        public void SetCurrentCommand(ITelegramBotCommand currentCommand)
        {
            TelegramBotCommand = currentCommand;
        }
    }
}
