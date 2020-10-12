using System;

namespace SB.TelegramBot
{
    /// <summary>
    /// 
    /// </summary>
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
    public class TelegramBotNearCommandAttribute : Attribute
    {
        /// <summary>
        /// 
        /// </summary>
        public Type NearCommandType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="nearCommandType"></param>
        public TelegramBotNearCommandAttribute(Type nearCommandType)
        {
            NearCommandType = nearCommandType;
        }
    }
}
