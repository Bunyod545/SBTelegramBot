using System.Collections.Generic;

namespace SB.TelegramBot.Services
{
    /// <summary>
    /// 
    /// </summary>
    public class TelegramBotUserInfo
    {
        /// <summary>
        /// 
        /// </summary>
        public long DbId { get; set; }

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
        public string CurrentCommandClrName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string CurrentCommandData { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string BackCommandHandlerClrName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string BackCommandClrName { get; set; }

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

        /// <summary>
        /// 
        /// </summary>
        public TelegramBotUserInfo()
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="chatId"></param>
        public TelegramBotUserInfo(long chatId)
        {
            ChatId = chatId;
        }
    }
}
