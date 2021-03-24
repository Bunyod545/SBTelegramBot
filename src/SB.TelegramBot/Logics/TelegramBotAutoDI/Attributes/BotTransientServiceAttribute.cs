namespace SB.TelegramBot
{
    /// <summary>
    /// 
    /// </summary>
    public class BotTransientServiceAttribute : BotServiceAttribute
    {
        /// <summary>
        /// 
        /// </summary>
        public BotTransientServiceAttribute()
        {
            LifeCycle = BotServiceLifeCycle.Transient;
        }
    }
}
