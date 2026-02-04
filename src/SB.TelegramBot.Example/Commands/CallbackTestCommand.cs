using System;

namespace SB.TelegramBot.Example.Commands
{
    /// <summary>
    /// 
    /// </summary>
    public class CallbackTestCommand : TelegramBotCallbackCommand
    {
        /// <summary>
        /// 
        /// </summary>
        public async override void Execute()
        {
            var data = CallbackQuery?.Data;
            if (data == null)
                return;

            if (data.Contains("ID:"))
            {
                var largeData = GetData<LargeDataModel>();
                await SendAnswerText($"Large Data Received! Title: {largeData.Title}", showAlert: true);
                await SendTextMessageAsync(
                    $"Large Data Details:\nTitle: {largeData.Title}\nDesc: {largeData.Description}\nLength: {largeData.LongText?.Length ?? 0} chars");
            }
            else
            {
                await SendAnswerText($"Small Data Received!", showAlert: true);
            }
        }
    }
}
