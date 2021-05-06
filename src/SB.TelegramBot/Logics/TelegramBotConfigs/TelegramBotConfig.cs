using System.Collections.Generic;

namespace SB.TelegramBot.Logics.TelegramBotConfigs
{
    /// <summary>
    /// 
    /// </summary>
    public class TelegramBotConfig
    {
        /// <summary>
        /// 
        /// </summary>
        public const string DefaultOptions = "Default";

        /// <summary>
        /// 
        /// </summary>
        public readonly static Dictionary<string, TelegramBotOptions> Options = new Dictionary<string, TelegramBotOptions>();

        /// <summary>
        /// 
        /// </summary>
        static TelegramBotConfig()
        {
            SetDefautOptions(new TelegramBotDefaultOptions());
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="defaultOptions"></param>
        public static void SetDefautOptions(TelegramBotOptions defaultOptions)
        {
            AddOrReplaceOption(DefaultOptions, defaultOptions);
        }

        /// <summary>
        /// 
        /// </summary>
        public static TelegramBotOptions GetDefaultOptions()
        {
            return GetOptions(DefaultOptions);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="optionKey"></param>
        /// <param name="options"></param>
        public static void AddOrReplaceOption(string optionKey, TelegramBotOptions options)
        {
            if(Options.ContainsKey(optionKey))
            {
                Options[optionKey] = options;
                return;
            }

            Options.Add(optionKey, options);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="optionKey"></param>
        public static TelegramBotOptions GetOptions(string optionKey)
        {
            if(Options.TryGetValue(optionKey, out var options))
                return options;

            options = new TelegramBotOptions();
            AddOrReplaceOption(optionKey, options);

            return options;
        }
    }
}
