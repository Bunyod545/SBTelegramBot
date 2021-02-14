using SB.TelegramBot.Logics.TelegramBotCommands.Factories.Models;
using System.Collections.Generic;
using System.Linq;
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
        public List<string> Roles { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        public TelegramBotCommandRole()
        {
            Roles = new List<string>();
        }

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
            var attrs = Info.ClrType.GetCustomAttributes<TelegramBotCommandRoleAttribute>();
            Roles = attrs.Select(s => s.Role).ToList();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="role"></param>
        /// <returns></returns>
        public virtual bool IsEqualRole(string role)
        {
            if (string.IsNullOrEmpty(role) && Roles.Count == 0)
                return true;

            return Roles.Contains(role);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        protected virtual string GetRole()
        {
            return string.Join(", ", Roles);
        }
    }
}
