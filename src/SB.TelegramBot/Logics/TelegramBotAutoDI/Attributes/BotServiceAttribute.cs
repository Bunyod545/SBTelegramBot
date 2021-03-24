using System;

namespace SB.TelegramBot
{
    /// <summary>
    /// 
    /// </summary>
    public class BotServiceAttribute : Attribute
    {
        /// <summary>
        /// 
        /// </summary>
        public BotServiceLifeCycle LifeCycle { get; set; }
    }
}
