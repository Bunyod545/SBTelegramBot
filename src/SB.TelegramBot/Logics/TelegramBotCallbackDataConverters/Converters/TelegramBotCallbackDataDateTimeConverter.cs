using System;

namespace SB.TelegramBot
{
    /// <summary>
    /// 
    /// </summary>
    public class TelegramBotCallbackDataDateTimeConverter : ITelegramBotCallbackDataConverter
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sbStringBuilder"></param>
        /// <param name="value"></param>
        public void Serialize(TelegramBotCallbackDataStringBuilder sbStringBuilder, object value)
        {
            if(value == null)
            {
                sbStringBuilder.AppendEmptyValue();
                return;
            }

            var date = (DateTime)value;
            var millisecounds = new DateTimeOffset(date).ToUnixTimeMilliseconds();
            sbStringBuilder.AppendValue(millisecounds.ToString());
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        public object Deserialize(Type type, string value)
        {
            if (value == string.Empty)
                return null;

            var milleseconds = long.Parse(value);
            
            var unixEpoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
    
            // Add milliseconds to get correct UTC DateTime
            var dateTimeUtc = unixEpoch.AddMilliseconds(milleseconds);

            return dateTimeUtc;
            // return new DateTimeOffset().AddMilliseconds(millisecounds).Date;
        }
    }
}
