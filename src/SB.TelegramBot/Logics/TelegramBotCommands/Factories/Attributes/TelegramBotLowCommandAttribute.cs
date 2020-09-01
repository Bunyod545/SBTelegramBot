using System;

namespace SB.TelegramBot
{
    /// <summary>
    /// 
    /// </summary>
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
    public class TelegramBotLowCommandAttribute : Attribute
    {
        /// <summary>
        /// 
        /// </summary>
        public Type LowCommand { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="lowCommand"></param>
        public TelegramBotLowCommandAttribute(Type lowCommand)
        {
            LowCommand = lowCommand;
        }
    }
}
