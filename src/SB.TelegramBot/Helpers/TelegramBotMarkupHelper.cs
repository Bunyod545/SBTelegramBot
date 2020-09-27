namespace SB.TelegramBot.Helpers
{
    /// <summary>
    /// 
    /// </summary>
    public class TelegramBotMarkupHelper
    {
        /// <summary>
        /// 
        /// </summary>
        public static string[] MarkupKeyWords = new[] { "_", "*", "`", "[" };

        /// <summary>
        /// 
        /// </summary>
        public const string Slash = @"\";

        /// <summary>
        /// 
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static string CloseKeyWords(string text)
        {
            if (string.IsNullOrEmpty(text))
                return text;

            foreach (var keyWord in MarkupKeyWords)
                text = text.Replace(keyWord, Slash + keyWord);

            return text;
        } 
    }
}
