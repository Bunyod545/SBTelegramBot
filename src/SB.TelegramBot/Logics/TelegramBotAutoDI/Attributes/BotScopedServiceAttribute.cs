namespace SB.TelegramBot
{
    /// <summary>
    /// 
    /// </summary>
    public class BotScopedServiceAttribute : BotServiceAttribute
    {
        /// <summary>
        /// 
        /// </summary>
        public BotScopedServiceAttribute()
        {
            LifeCycle = BotServiceLifeCycle.Scoped;
        }
    }
}
