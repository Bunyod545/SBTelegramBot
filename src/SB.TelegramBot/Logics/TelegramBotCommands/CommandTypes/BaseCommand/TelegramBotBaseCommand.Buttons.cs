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
            return ServicesContainer.GetService<KeyboardButtonBuilder>();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public InlineKeyboardButtonBuilder CreateInlineKeyboardButtonBuilder()
        {
            return ServicesContainer.GetService<InlineKeyboardButtonBuilder>();
        }
    }
}
