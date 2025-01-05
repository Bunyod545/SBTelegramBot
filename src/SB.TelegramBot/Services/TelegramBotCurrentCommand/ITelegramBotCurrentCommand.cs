namespace SB.TelegramBot.Services
{
    /// <summary>
    /// 
    /// </summary>
    public interface ITelegramBotCurrentCommand
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        ITelegramBotCommand GetCurrentCommand();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="currentCommand"></param>
        /// <returns></returns>
        void SetCurrentCommand(ITelegramBotCommand currentCommand);
    }
}
