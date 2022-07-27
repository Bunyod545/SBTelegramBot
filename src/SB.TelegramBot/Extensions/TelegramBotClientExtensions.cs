using SB.TelegramBot.Logics.TelegramBot.Requests;
using SB.TelegramBot.Requests;
using Telegram.Bot;
using Telegram.Bot.Requests;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Types.ReplyMarkups;

namespace SB.TelegramBot
{
    /// <summary>
    /// 
    /// </summary>
    public static class TelegramBotClientExtensions
    {
        /// <summary>
        /// Use this method to send text messages. On success, the sent Description is returned.
        /// </summary>
        /// <param name="chatId"><see cref="ChatId"/> for the target chat</param>
        /// <param name="text">Text of the message to be sent</param>
        /// <param name="parseMode">Change, if you want Telegram apps to show bold, italic, fixed-width text or inline URLs in your bot's message.</param>
        /// <param name="disableWebPagePreview">Disables link previews for links in this message</param>
        /// <param name="disableNotification">Sends the message silently. iOS users will not receive a notification, Android users will receive a notification with no sound.</param>
        /// <param name="replyToMessageId">If the message is a reply, ID of the original message</param>
        /// <param name="replyMarkup">Additional interface options. A JSON-serialized object for a custom reply keyboard, instructions to hide keyboard or to force a reply from the user.</param>
        /// <param name="entities">Optional. For text messages, special entities like usernames, URLs, bot commands, etc. that appear in the text.</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>On success, the sent Description is returned.</returns>
        /// <see href="https://core.telegram.org/bots/api#sendmessage"/>
        public static Task<Message> SendTextMessageV2Async(
            this ITelegramBotClient client,
            ChatId chatId,
            string text,
            ParseMode parseMode = default,
            bool disableWebPagePreview = default,
            bool disableNotification = default,
            int replyToMessageId = default,
            IReplyMarkup replyMarkup = default,
            MessageEntity[] entities = default,
            CancellationToken cancellationToken = default
        ) =>
            client.MakeRequestAsync(new SbSendMessageRequest(chatId, text)
            {
                ParseMode = parseMode,
                DisableWebPagePreview = disableWebPagePreview,
                DisableNotification = disableNotification,
                ReplyToMessageId = replyToMessageId,
                ReplyMarkup = replyMarkup,
                Entities = entities
            }, cancellationToken);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="chatId"></param>
        /// <param name="messageId"></param>
        /// <param name="text"></param>
        /// <param name="parseMode"></param>
        /// <param name="disableWebPagePreview"></param>
        /// <param name="replyMarkup"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static Task<Message> EditMessageTextV2Async(
            this ITelegramBotClient client,
            ChatId chatId,
            int messageId,
            string text,
            ParseMode parseMode = default,
            bool disableWebPagePreview = default,
            InlineKeyboardMarkup replyMarkup = default,
            MessageEntity[] entities = default,
            CancellationToken cancellationToken = default
        ) =>
            client.MakeRequestAsync(new SbEditMessageTextRequest(chatId, messageId, text)
            {
                ParseMode = parseMode,
                DisableWebPagePreview = disableWebPagePreview,
                ReplyMarkup = replyMarkup,
                Entities = entities
            }, cancellationToken);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="client"></param>
        /// <param name="inlineMessageId"></param>
        /// <param name="text"></param>
        /// <param name="parseMode"></param>
        /// <param name="disableWebPagePreview"></param>
        /// <param name="replyMarkup"></param>
        /// <param name="entities"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static Task EditMessageTextV2Async(
            this ITelegramBotClient client,
            string inlineMessageId,
            string text,
            ParseMode parseMode = default,
            bool disableWebPagePreview = default,
            InlineKeyboardMarkup replyMarkup = default,
            MessageEntity[] entities = default,
            CancellationToken cancellationToken = default
        ) =>
            client.MakeRequestAsync(new SbEditInlineMessageTextRequest(inlineMessageId, text)
            {
                DisableWebPagePreview = disableWebPagePreview,
                ReplyMarkup = replyMarkup,
                ParseMode = parseMode,
                Entities = entities
            }, cancellationToken);

        /// <summary>
        /// Use this method to delete a message, including service messages, with the following limitations:
        /// <list type="bullet">
        /// <item>A message can only be deleted if it was sent less than 48 hours ago</item>
        /// <item>A dice message in a private chat can only be deleted if it was sent more than 24 hours ago</item>
        /// <item>Bots can delete outgoing messages in private chats, groups, and supergroups</item>
        /// <item>Bots can delete incoming messages in private chats</item>
        /// <item>Bots granted can_post_messages permissions can delete outgoing messages in channels</item>
        /// <item>If the bot is an administrator of a group, it can delete any message there</item>
        /// <item>
        /// If the bot has can_delete_messages permission in a supergroup or a channel, it can delete any message there
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="botClient">An instance of <see cref="ITelegramBotClient"/></param>
        /// <param name="chatId">
        /// Unique identifier for the target chat or username of the target channel
        /// (in the format <c>@channelusername</c>)
        /// </param>
        /// <param name="messageId">Identifier of the message to delete</param>
        /// <param name="cancellationToken">
        /// A cancellation token that can be used by other objects or threads to receive notice of cancellation
        /// </param>
        public static Task DeleteMessageAsync(
            this ITelegramBotClient botClient,
            ChatId chatId,
            int messageId,
            CancellationToken cancellationToken = default)
        => botClient.MakeRequestAsync(request: new SbDeleteMessageRequest(chatId, messageId), cancellationToken);

        /// <summary>
        /// Use this method to delete a chat photo. Photos can't be changed for private chats. The bot must be an
        /// administrator in the chat for this to work and must have the appropriate admin rights
        /// </summary>
        /// <param name="botClient">An instance of <see cref="ITelegramBotClient"/></param>
        /// <param name="chatId">
        /// Unique identifier for the target chat or username of the target channel (in the format @channelusername)
        /// </param>
        /// <param name="cancellationToken">
        /// A cancellation token that can be used by other objects or threads to receive notice of cancellation
        /// </param>
        public static Task DeleteChatPhotoAsync(
            this ITelegramBotClient botClient,
            ChatId chatId,
            CancellationToken cancellationToken = default
        ) => botClient.MakeRequestAsync(request: new SbDeleteChatPhotoRequest(chatId), cancellationToken);

        /// <summary>
        /// Use this method to delete a group sticker set from a supergroup. The bot must be an administrator in the
        /// chat for this to work and must have the appropriate admin rights. Use the field
        /// <see cref="Chat.CanSetStickerSet"/> optionally returned in <see cref="GetChatAsync"/> requests to
        /// check if the bot can use this method
        /// </summary>
        /// <param name="botClient">An instance of <see cref="ITelegramBotClient"/></param>
        /// <param name="chatId">
        /// Unique identifier for the target chat or username of the target channel
        /// (in the format <c>@channelusername</c>)
        /// </param>
        /// <param name="cancellationToken">
        /// A cancellation token that can be used by other objects or threads to receive notice of cancellation
        /// </param>
        public static Task DeleteChatStickerSetAsync(
            this ITelegramBotClient botClient,
            ChatId chatId,
            CancellationToken cancellationToken = default
        ) => botClient.MakeRequestAsync(request: new DeleteChatStickerSetRequest(chatId), cancellationToken);

        /// <summary>
        /// Use this method to delete a sticker from a set created by the bot.
        /// </summary>
        /// <param name="botClient">An instance of <see cref="ITelegramBotClient"/></param>
        /// <param name="sticker">File identifier of the sticker</param>
        /// <param name="cancellationToken">
        /// A cancellation token that can be used by other objects or threads to receive notice of cancellation
        /// </param>
        public static Task DeleteStickerFromSetAsync(
            this ITelegramBotClient botClient,
            string sticker,
            CancellationToken cancellationToken = default
        ) => botClient.MakeRequestAsync(request: new DeleteStickerFromSetRequest(sticker), cancellationToken);
    }
}
