using SB.TelegramBot.Logics.TelegramBotCommands.Factories.Models;
using System.Reflection;

namespace SB.TelegramBot.Services
{
    /// <summary>
    /// 
    /// </summary>
    public class TelegramBotCommandRole : ITelegramBotCommandRole
    {
        /// <summary>
        /// 
        /// </summary>
        public TelegramBotCommandInfo Info { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        public string Role { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="info"></param>
        public virtual void Initialize(TelegramBotCommandInfo info)
        {
            Info = info;
            InitializeWithAttribute();
        }

        /// <summary>
        /// 
        /// </summary>
        protected virtual void InitializeWithAttribute()
        {
            var attr = Info.ClrType.GetCustomAttribute<TelegramBotCommandRoleAttribute>();
            Role = attr?.Role;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="role"></param>
        /// <returns></returns>
        public virtual bool IsEqualRole(string role)
        {
            if (Role == null)
                return true;

            return Role == role;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public virtual string GetRole()
        {
            return Role;
        }
    }
}
