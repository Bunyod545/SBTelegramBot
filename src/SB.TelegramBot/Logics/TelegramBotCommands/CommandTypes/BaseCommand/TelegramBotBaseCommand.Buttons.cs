namespace SB.TelegramBot
{
    /// <summary>
    /// 
    /// </summary>
    public abstract partial class TelegramBotBaseCommand
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public KeyboardButtonBuilder CreateKeyboardButtonBuilder()
        {
            return ServicesProvider.GetService<KeyboardButtonBuilder>();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public InlineKeyboardButtonBuilder CreateInlineKeyboardButtonBuilder()
        {
            return ServicesProvider.GetService<InlineKeyboardButtonBuilder>();
        }
    }
}
