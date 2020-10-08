using System;

namespace SB.TelegramBot
{
    /// <summary>
    /// 
    /// </summary>
    public class TelegramBotCallbackDataGuidConverter : ITelegramBotCallbackDataConverter
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sbStringBuilder"></param>
        /// <param name="value"></param>
        public void Serialize(TelegramBotCallbackDataStringBuilder sbStringBuilder, object value)
        {
            if (value == null)
            {
                sbStringBuilder.AppendEmptyValue();
                return;
            }

            var guid = Guid.Parse(value.ToString());
            sbStringBuilder.AppendValue(guid.ToString());
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="type"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public object Deserialize(Type type, string value)
        {
            if (string.IsNullOrEmpty(value))
                return null;

            return Guid.Parse(value);
        }
    }
}
