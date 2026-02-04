using System;

namespace SB.TelegramBot.Databases.Tables
{
    /// <summary>
    /// 
    /// </summary>
    public class TelegramBotDbCallbackData
    {
        /// <summary>
        /// 
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Data { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public DateTime CreatedDateTime { get; set; } = DateTime.Now;
    }
}
