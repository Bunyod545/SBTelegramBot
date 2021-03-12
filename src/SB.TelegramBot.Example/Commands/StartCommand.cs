using SB.TelegramBot;
using SB.TelegramBot.Example.Resources.Messages;
using SB.TeleramBot.Example.Commands.Languages.LanguageEnCommands.Models;
using Telegram.Bot.Types.ReplyMarkups;

namespace SB.TeleramBot.Example.Commands
{
    /// <summary>
    /// 
    /// </summary>
    [TelegramBotCommandName("/start")]
    public class StartCommand : TelegramBotPublicCommand
    {
        /// <summary>
        /// 
        /// </summary>
        public override void Execute()
        {
            ShowInlineKeyboards();
            ShowKeyboard();
        }


        /// <summary>
        /// 
        /// </summary>
        private void ShowInlineKeyboards()
        {
            var buttonsBuilder = new InlineKeyboardButtonBuilder();
            buttonsBuilder.AddColumnButton()
                .WithText("O'zbek tili")
                .WithCommand<LanguageUzCommand>();
            buttonsBuilder.AddColumnButton()
                .WithText("Rus tili")
                .WithCommand<LanguageRuCommand>();
            buttonsBuilder.EndOfColumn();

            buttonsBuilder.AddColumnButton()
                            .WithText("O'zbek tili")
                            .WithCommand<LanguageUzCommand>();
            buttonsBuilder.AddColumnButton()
                .WithText("Rus tili")
                .WithCommand<LanguageRuCommand>();

            buttonsBuilder.AddRowButton()
                .WithText("O'zbek tili")
                .WithCommand<LanguageUzCommand>();

            var buttons = buttonsBuilder.Build();
            MessageService.SendMessage("Test columns", replyMarkup: buttons);
        }

        /// <summary>
        /// 
        /// </summary>
        private void ShowKeyboard()
        {
            var buttonsBuilder = new KeyboardButtonBuilder();
            buttonsBuilder
                .AddColumnButton("Column 1")
                .WithRequestContact("Contact");
            
            buttonsBuilder
                .AddColumnButton("Column 2")
                .WithRequestLocation("Location");

            buttonsBuilder
                .AddRowButton("ContactRowButton")
                .WithRequestContact("RequestContact");

            buttonsBuilder
                .AddRowButton("LacationRowButton2")
                .WithRequestLocation("RequestLocation");

            buttonsBuilder.AddColumnButton("Column 3");
            buttonsBuilder.AddColumnButton("Column 4");

            var buttons = buttonsBuilder.Build();
            buttons.ResizeKeyboard = true;

            MessageService.SendMessage("Test", replyMarkup: buttons);
        }
    }
}
