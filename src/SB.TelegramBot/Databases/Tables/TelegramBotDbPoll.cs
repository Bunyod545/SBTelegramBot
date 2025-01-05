namespace SB.TelegramBot.Databases.Tables
{
    /// <summary>
    /// 
    /// </summary>
    public class TelegramBotDbPoll
    {
        /// <summary>
        /// 
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string ChatId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string TopicId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string PollId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Question { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string PollCommand { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string PollCommandData { get; set; }
    }
}
