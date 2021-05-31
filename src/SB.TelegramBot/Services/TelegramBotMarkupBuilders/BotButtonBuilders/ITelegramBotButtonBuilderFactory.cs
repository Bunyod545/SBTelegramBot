namespace SB.TelegramBot
{
    /// <summary>
    /// 
    /// </summary>
    public interface ITelegramBotButtonBuilderFactory
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        KeyboardButtonBuilder CreateKeyboardButtonBuilder();

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        InlineKeyboardButtonBuilder CreateInlineKeyboardButtonBuilder();
    }
}
