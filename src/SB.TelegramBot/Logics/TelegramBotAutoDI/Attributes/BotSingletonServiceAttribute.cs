namespace SB.TelegramBot
{
    /// <summary>
    /// 
    /// </summary>
    public class BotSingletonServiceAttribute : BotServiceAttribute
    {
        /// <summary>
        /// 
        /// </summary>
        public BotSingletonServiceAttribute()
        {
            LifeCycle = BotServiceLifeCycle.Singleton;
        }
    }
}
