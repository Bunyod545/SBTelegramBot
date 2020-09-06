using System;

namespace SB.TelegramBot.Logics.TelegramBotCommands.Factories.Attributes
{
    /// <summary>
    /// 
    /// </summary>
    [AttributeUsage(AttributeTargets.Class)]
    public class TelegramBotCommandRoleAttribute : Attribute
    {
        /// <summary>
        /// 
        /// </summary>
        public string Role { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="role"></param>
        public TelegramBotCommandRoleAttribute(string role)
        {
            Role = role;
        }
    }
}
