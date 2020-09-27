using System.Collections.Generic;

namespace SB.TelegramBot.Databases.Tables
{
    /// <summary>
    /// 
    /// </summary>
    public class TelegramBotDbUser
    {
        /// <summary>
        /// 
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public long ChatId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Language { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string CurrentCommand { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public List<long> PriorityCommands { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string BackCommand { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string BackCommandHandler { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string UserRole { get; set; }
    }
}
