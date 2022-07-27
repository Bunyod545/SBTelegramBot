using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Types.InputFiles;
using Telegram.Bot.Types.Payments;
using Telegram.Bot.Types.ReplyMarkups;

namespace SB.TelegramBot
{
    /// <summary>
    /// 
    /// </summary>
    public abstract partial class TelegramBotBaseCommand
    {
        /// <summary>
        /// Use this method to send animation files (GIF or H.264/MPEG-4 AVC video without sound). Bots can currently
        /// send animation files of up to 50 MB in size, this limit may be changed in the future.
        /// </summary>
        /// <param name="botClient">An instance of <see cref="ITelegramBotClient"/></param>
        /// <param name="chatId">
        /// Unique identifier for the target chat or username of the target channel
        /// (in the format <c>@channelusername</c>)
        /// </param>
        /// <param name="animation">
        /// Animation to send. Pass a <see cref="InputTelegramFile.FileId"/> as String to send an animation that
        /// exists on the Telegram servers (recommended), pass an HTTP URL as a String for Telegram to get an
        /// animation from the Internet, or upload a new animation using multipart/form-data
        /// </param>
        /// <param name="duration">Duration of sent animation in seconds</param>
        /// <param name="width">Animation width</param>
        /// <param name="height">Animation height</param>
        /// <param name="thumb">
        /// Thumbnail of the file sent; can be ignored if thumbnail generation for the file is supported server-side.
        /// The thumbnail should be in JPEG format and less than 200 kB in size. A thumbnail's width and height should
        /// not exceed 320. Ignored if the file is not uploaded using multipart/form-data. Thumbnails can't be reused
        /// and can be only uploaded as a new file, so you can pass "attach://&lt;file_attach_name&gt;" if the
        /// thumbnail was uploaded using multipart/form-data under &lt;file_attach_name&gt;
        /// </param>
        /// <param name="caption">
        /// Animation caption (may also be used when resending animation by <see cref="InputTelegramFile.FileId"/>),
        /// 0-1024 characters after entities parsing
        /// </param>
        /// <param name="parseMode">
        /// Mode for parsing entities in the new caption. See
        /// <a href="https://core.telegram.org/bots/api#formatting-options">formatting</a> options for
        /// more details
        /// </param>
        /// <param name="captionEntities">
        /// List of special entities that appear in the caption, which can be specified instead
        /// of <see cref="ParseMode"/>
        /// </param>
        /// <param name="disableNotification">
        /// Sends the message silently. Users will receive a notification with no sound
        /// </param>
        /// <param name="protectContent">Protects the contents of sent messages from forwarding and saving</param>
        /// <param name="replyToMessageId">If the message is a reply, ID of the original message</param>
        /// <param name="allowSendingWithoutReply">
        /// Pass <c>true</c>, if the message should be sent even if the specified replied-to message is not found
        /// </param>
        /// <param name="replyMarkup">
        /// Additional interface options. An <see cref="InlineKeyboardMarkup">inline keyboard</see>,
        /// <see cref="ReplyKeyboardMarkup">custom reply keyboard</see>, instructions to
        /// <see cref="ReplyKeyboardRemove">remove reply keyboard</see> or to
        /// <see cref="ForceReplyMarkup">force a reply</see> from the user
        /// </param>
        /// <param name="cancellationToken">
        /// A cancellation token that can be used by other objects or threads to receive notice of cancellation
        /// </param>
        /// <returns>On success, the sent <see cref="Message"/> is returned.</returns>
        public Task<Message> SendAnimationAsync(InputOnlineFile animation, int duration = 0, int width = 0, int height = 0, InputMedia thumb = null, string caption = null, ParseMode parseMode = 0, bool disableNotification = false, int replyToMessageId = 0, IReplyMarkup replyMarkup = null, CancellationToken cancellationToken = default)
        {
            return SendAnimationAsync(animation, duration, width, height, thumb, caption, parseMode, disableNotification, replyToMessageId, replyMarkup, cancellationToken);
        }

        /// <summary>
        /// Use this method to send animation files (GIF or H.264/MPEG-4 AVC video without sound). Bots can currently
        /// send animation files of up to 50 MB in size, this limit may be changed in the future.
        /// </summary>
        /// <param name="botClient">An instance of <see cref="ITelegramBotClient"/></param>
        /// <param name="chatId">
        /// Unique identifier for the target chat or username of the target channel
        /// (in the format <c>@channelusername</c>)
        /// </param>
        /// <param name="animation">
        /// Animation to send. Pass a <see cref="InputTelegramFile.FileId"/> as String to send an animation that
        /// exists on the Telegram servers (recommended), pass an HTTP URL as a String for Telegram to get an
        /// animation from the Internet, or upload a new animation using multipart/form-data
        /// </param>
        /// <param name="duration">Duration of sent animation in seconds</param>
        /// <param name="width">Animation width</param>
        /// <param name="height">Animation height</param>
        /// <param name="thumb">
        /// Thumbnail of the file sent; can be ignored if thumbnail generation for the file is supported server-side.
        /// The thumbnail should be in JPEG format and less than 200 kB in size. A thumbnail's width and height should
        /// not exceed 320. Ignored if the file is not uploaded using multipart/form-data. Thumbnails can't be reused
        /// and can be only uploaded as a new file, so you can pass "attach://&lt;file_attach_name&gt;" if the
        /// thumbnail was uploaded using multipart/form-data under &lt;file_attach_name&gt;
        /// </param>
        /// <param name="caption">
        /// Animation caption (may also be used when resending animation by <see cref="InputTelegramFile.FileId"/>),
        /// 0-1024 characters after entities parsing
        /// </param>
        /// <param name="parseMode">
        /// Mode for parsing entities in the new caption. See
        /// <a href="https://core.telegram.org/bots/api#formatting-options">formatting</a> options for
        /// more details
        /// </param>
        /// <param name="captionEntities">
        /// List of special entities that appear in the caption, which can be specified instead
        /// of <see cref="ParseMode"/>
        /// </param>
        /// <param name="disableNotification">
        /// Sends the message silently. Users will receive a notification with no sound
        /// </param>
        /// <param name="protectContent">Protects the contents of sent messages from forwarding and saving</param>
        /// <param name="replyToMessageId">If the message is a reply, ID of the original message</param>
        /// <param name="allowSendingWithoutReply">
        /// Pass <c>true</c>, if the message should be sent even if the specified replied-to message is not found
        /// </param>
        /// <param name="replyMarkup">
        /// Additional interface options. An <see cref="InlineKeyboardMarkup">inline keyboard</see>,
        /// <see cref="ReplyKeyboardMarkup">custom reply keyboard</see>, instructions to
        /// <see cref="ReplyKeyboardRemove">remove reply keyboard</see> or to
        /// <see cref="ForceReplyMarkup">force a reply</see> from the user
        /// </param>
        /// <param name="cancellationToken">
        /// A cancellation token that can be used by other objects or threads to receive notice of cancellation
        /// </param>
        /// <returns>On success, the sent <see cref="Message"/> is returned.</returns>
        public Task<Message> SendAnimationAsync(ChatId chatId, InputOnlineFile animation, int duration = 0, int width = 0, int height = 0, InputMedia thumb = null, string caption = null, ParseMode parseMode = 0, bool disableNotification = false, int replyToMessageId = 0, IReplyMarkup replyMarkup = null, CancellationToken cancellationToken = default)
        {
            return SendAnimationAsync(chatId, animation, duration, width, height, thumb, caption, parseMode, disableNotification, replyToMessageId, replyMarkup, cancellationToken);
        }

        /// <summary>
        /// Use this method to send audio files, if you want Telegram clients to display them in the music player.
        /// Your audio must be in the .MP3 or .M4A format. Bots can currently send audio files of up to 50 MB in size,
        /// this limit may be changed in the future.
        /// </summary>
        /// <param name="botClient">An instance of <see cref="ITelegramBotClient"/></param>
        /// <param name="chatId">
        /// Unique identifier for the target chat or username of the target channel
        /// (in the format <c>@channelusername</c>)
        /// </param>
        /// <param name="audio">
        /// Audio file to send. Pass a <see cref="InputTelegramFile.FileId"/> as String to send an audio file that
        /// exists on the Telegram servers (recommended), pass an HTTP URL as a String for Telegram to get an audio
        /// file from the Internet, or upload a new one using multipart/form-data
        /// </param>
        /// <param name="caption">Audio caption, 0-1024 characters after entities parsing</param>
        /// <param name="parseMode">
        /// Mode for parsing entities in the new caption. See
        /// <a href="https://core.telegram.org/bots/api#formatting-options">formatting</a> options for
        /// more details
        /// </param>
        /// <param name="captionEntities">
        /// List of special entities that appear in the caption, which can be specified instead
        /// of <see cref="ParseMode"/>
        /// </param>
        /// <param name="duration">Duration of the audio in seconds</param>
        /// <param name="performer">Performer</param>
        /// <param name="title">Track name</param>
        /// <param name="thumb">
        /// Thumbnail of the file sent; can be ignored if thumbnail generation for the file is supported server-side.
        /// The thumbnail should be in JPEG format and less than 200 kB in size. A thumbnail's width and height
        /// should not exceed 320. Ignored if the file is not uploaded using multipart/form-data. Thumbnails can't be
        /// reused and can be only uploaded as a new file, so you can pass "attach://&lt;file_attach_name&gt;" if the
        /// thumbnail was uploaded using multipart/form-data under &lt;file_attach_name&gt;
        /// </param>
        /// <param name="disableNotification">
        /// Sends the message silently. Users will receive a notification with no sound
        /// </param>
        /// <param name="protectContent">Protects the contents of sent messages from forwarding and saving</param>
        /// <param name="replyToMessageId">If the message is a reply, ID of the original message</param>
        /// <param name="allowSendingWithoutReply">
        /// Pass <c>true</c>, if the message should be sent even if the specified replied-to message is not found
        /// </param>
        /// <param name="replyMarkup">
        /// Additional interface options. An <see cref="InlineKeyboardMarkup">inline keyboard</see>,
        /// <see cref="ReplyKeyboardMarkup">custom reply keyboard</see>, instructions to
        /// <see cref="ReplyKeyboardRemove">remove reply keyboard</see> or to
        /// <see cref="ForceReplyMarkup">force a reply</see> from the user
        /// </param>
        /// <param name="cancellationToken">
        /// A cancellation token that can be used by other objects or threads to receive notice of cancellation
        /// </param>
        /// <returns>On success, the sent <see cref="Message"/> is returned.</returns>
        public Task<Message> SendAudioAsync(InputOnlineFile audio, string caption = null, ParseMode parseMode = 0, int duration = 0, string performer = null, string title = null, bool disableNotification = false, int replyToMessageId = 0, IReplyMarkup replyMarkup = null, CancellationToken cancellationToken = default, InputMedia thumb = null)
        {
            return Client.SendAudioAsync(ChatId, audio, caption, parseMode, null, duration, performer, title, thumb, disableNotification, null, replyToMessageId, null, replyMarkup, cancellationToken);
        }

        /// <summary>
        /// Use this method to send audio files, if you want Telegram clients to display them in the music player.
        /// Your audio must be in the .MP3 or .M4A format. Bots can currently send audio files of up to 50 MB in size,
        /// this limit may be changed in the future.
        /// </summary>
        /// <param name="botClient">An instance of <see cref="ITelegramBotClient"/></param>
        /// <param name="chatId">
        /// Unique identifier for the target chat or username of the target channel
        /// (in the format <c>@channelusername</c>)
        /// </param>
        /// <param name="audio">
        /// Audio file to send. Pass a <see cref="InputTelegramFile.FileId"/> as String to send an audio file that
        /// exists on the Telegram servers (recommended), pass an HTTP URL as a String for Telegram to get an audio
        /// file from the Internet, or upload a new one using multipart/form-data
        /// </param>
        /// <param name="caption">Audio caption, 0-1024 characters after entities parsing</param>
        /// <param name="parseMode">
        /// Mode for parsing entities in the new caption. See
        /// <a href="https://core.telegram.org/bots/api#formatting-options">formatting</a> options for
        /// more details
        /// </param>
        /// <param name="captionEntities">
        /// List of special entities that appear in the caption, which can be specified instead
        /// of <see cref="ParseMode"/>
        /// </param>
        /// <param name="duration">Duration of the audio in seconds</param>
        /// <param name="performer">Performer</param>
        /// <param name="title">Track name</param>
        /// <param name="thumb">
        /// Thumbnail of the file sent; can be ignored if thumbnail generation for the file is supported server-side.
        /// The thumbnail should be in JPEG format and less than 200 kB in size. A thumbnail's width and height
        /// should not exceed 320. Ignored if the file is not uploaded using multipart/form-data. Thumbnails can't be
        /// reused and can be only uploaded as a new file, so you can pass "attach://&lt;file_attach_name&gt;" if the
        /// thumbnail was uploaded using multipart/form-data under &lt;file_attach_name&gt;
        /// </param>
        /// <param name="disableNotification">
        /// Sends the message silently. Users will receive a notification with no sound
        /// </param>
        /// <param name="protectContent">Protects the contents of sent messages from forwarding and saving</param>
        /// <param name="replyToMessageId">If the message is a reply, ID of the original message</param>
        /// <param name="allowSendingWithoutReply">
        /// Pass <c>true</c>, if the message should be sent even if the specified replied-to message is not found
        /// </param>
        /// <param name="replyMarkup">
        /// Additional interface options. An <see cref="InlineKeyboardMarkup">inline keyboard</see>,
        /// <see cref="ReplyKeyboardMarkup">custom reply keyboard</see>, instructions to
        /// <see cref="ReplyKeyboardRemove">remove reply keyboard</see> or to
        /// <see cref="ForceReplyMarkup">force a reply</see> from the user
        /// </param>
        /// <param name="cancellationToken">
        /// A cancellation token that can be used by other objects or threads to receive notice of cancellation
        /// </param>
        /// <returns>On success, the sent <see cref="Message"/> is returned.</returns>
        public Task<Message> SendAudioAsync(ChatId chatId, InputOnlineFile audio, string caption = null, ParseMode parseMode = 0, int duration = 0, string performer = null, string title = null, bool disableNotification = false, int replyToMessageId = 0, IReplyMarkup replyMarkup = null, CancellationToken cancellationToken = default, InputMedia thumb = null)
        {
            return Client.SendAudioAsync(chatId, audio, caption, parseMode, null, duration, performer, title, thumb, disableNotification, null, replyToMessageId, null, replyMarkup, cancellationToken);
        }

        /// <summary>
        /// Use this method when you need to tell the user that something is happening on the bot’s side. The status is
        /// set for 5 seconds or less (when a message arrives from your bot, Telegram clients clear its typing status).
        /// </summary>
        /// <example>
        /// <para>
        /// The <a href="https://t.me/imagebot">ImageBot</a> needs some time to process a request and upload the
        /// image. Instead of sending a text message along the lines of “Retrieving image, please wait…”, the bot may
        /// use <see cref="SendChatActionAsync"/> with <see cref="Action"/> = <see cref="ChatAction.UploadPhoto"/>.
        /// The user will see a “sending photo” status for the bot.
        /// </para>
        /// <para>
        /// We only recommend using this method when a response from the bot will take a <b>noticeable</b> amount of
        /// time to arrive.
        /// </para>
        /// </example>
        /// <param name="botClient">An instance of <see cref="ITelegramBotClient"/></param>
        /// <param name="chatId">
        /// Unique identifier for the target chat or username of the target channel
        /// (in the format <c>@channelusername</c>)
        /// </param>
        /// <param name="chatAction">
        /// Type of action to broadcast. Choose one, depending on what the user is about to receive:
        /// <see cref="ChatAction.Typing"/> for <see cref="SendTextMessageAsync">text messages</see>,
        /// <see cref="ChatAction.UploadPhoto"/> for <see cref="SendPhotoAsync">photos</see>,
        /// <see cref="ChatAction.RecordVideo"/> or <see cref="ChatAction.UploadVideo"/> for
        /// <see cref="SendVideoAsync">videos</see>, <see cref="ChatAction.RecordVoice"/> or
        /// <see cref="ChatAction.UploadVoice"/> for <see cref="SendVoiceAsync">voice notes</see>,
        /// <see cref="ChatAction.UploadDocument"/> for <see cref="SendDocumentAsync">general files</see>,
        /// <see cref="ChatAction.FindLocation"/> for <see cref="SendLocationAsync">location data</see>,
        /// <see cref="ChatAction.RecordVideoNote"/> or <see cref="ChatAction.UploadVideoNote"/> for
        /// <see cref="SendVideoNoteAsync">video notes</see>
        /// </param>
        /// <param name="cancellationToken">
        /// A cancellation token that can be used by other objects or threads to receive notice of cancellation
        /// </param>
        public Task SendChatActionAsync(ChatAction chatAction, CancellationToken cancellationToken = default)
        {
            return Client.SendChatActionAsync(ChatId, chatAction, cancellationToken);
        }

        /// <summary>
        /// Use this method when you need to tell the user that something is happening on the bot’s side. The status is
        /// set for 5 seconds or less (when a message arrives from your bot, Telegram clients clear its typing status).
        /// </summary>
        /// <example>
        /// <para>
        /// The <a href="https://t.me/imagebot">ImageBot</a> needs some time to process a request and upload the
        /// image. Instead of sending a text message along the lines of “Retrieving image, please wait…”, the bot may
        /// use <see cref="SendChatActionAsync"/> with <see cref="Action"/> = <see cref="ChatAction.UploadPhoto"/>.
        /// The user will see a “sending photo” status for the bot.
        /// </para>
        /// <para>
        /// We only recommend using this method when a response from the bot will take a <b>noticeable</b> amount of
        /// time to arrive.
        /// </para>
        /// </example>
        /// <param name="botClient">An instance of <see cref="ITelegramBotClient"/></param>
        /// <param name="chatId">
        /// Unique identifier for the target chat or username of the target channel
        /// (in the format <c>@channelusername</c>)
        /// </param>
        /// <param name="chatAction">
        /// Type of action to broadcast. Choose one, depending on what the user is about to receive:
        /// <see cref="ChatAction.Typing"/> for <see cref="SendTextMessageAsync">text messages</see>,
        /// <see cref="ChatAction.UploadPhoto"/> for <see cref="SendPhotoAsync">photos</see>,
        /// <see cref="ChatAction.RecordVideo"/> or <see cref="ChatAction.UploadVideo"/> for
        /// <see cref="SendVideoAsync">videos</see>, <see cref="ChatAction.RecordVoice"/> or
        /// <see cref="ChatAction.UploadVoice"/> for <see cref="SendVoiceAsync">voice notes</see>,
        /// <see cref="ChatAction.UploadDocument"/> for <see cref="SendDocumentAsync">general files</see>,
        /// <see cref="ChatAction.FindLocation"/> for <see cref="SendLocationAsync">location data</see>,
        /// <see cref="ChatAction.RecordVideoNote"/> or <see cref="ChatAction.UploadVideoNote"/> for
        /// <see cref="SendVideoNoteAsync">video notes</see>
        /// </param>
        /// <param name="cancellationToken">
        /// A cancellation token that can be used by other objects or threads to receive notice of cancellation
        /// </param>
        public Task SendChatActionAsync(ChatId chatId, ChatAction chatAction, CancellationToken cancellationToken = default)
        {
            return Client.SendChatActionAsync(chatId, chatAction, cancellationToken);
        }

        /// <summary>
        /// Use this method to send phone contacts.
        /// </summary>
        /// <param name="botClient">An instance of <see cref="ITelegramBotClient"/></param>
        /// <param name="chatId">
        /// Unique identifier for the target chat or username of the target channel
        /// (in the format <c>@channelusername</c>)
        /// </param>
        /// <param name="phoneNumber">Contact's phone number</param>
        /// <param name="firstName">Contact's first name</param>
        /// <param name="lastName">Contact's last name</param>
        /// <param name="vCard">Additional data about the contact in the form of a vCard, 0-2048 bytes</param>
        /// <param name="disableNotification">
        /// Sends the message silently. Users will receive a notification with no sound
        /// </param>
        /// <param name="protectContent">Protects the contents of sent messages from forwarding and saving</param>
        /// <param name="replyToMessageId">If the message is a reply, ID of the original message</param>
        /// <param name="allowSendingWithoutReply">
        /// Pass <c>true</c>, if the message should be sent even if the specified replied-to message is not found
        /// </param>
        /// <param name="replyMarkup">
        /// Additional interface options. An <see cref="InlineKeyboardMarkup">inline keyboard</see>,
        /// <see cref="ReplyKeyboardMarkup">custom reply keyboard</see>, instructions to
        /// <see cref="ReplyKeyboardRemove">remove reply keyboard</see> or to
        /// <see cref="ForceReplyMarkup">force a reply</see> from the user
        /// </param>
        /// <param name="cancellationToken">
        /// A cancellation token that can be used by other objects or threads to receive notice of cancellation
        /// </param>
        /// <returns>On success, the sent <see cref="Message"/> is returned.</returns>
        public Task<Message> SendContactAsync(string phoneNumber, string firstName, string? lastName = null, string? vCard = null, bool? disableNotification = null, bool? protectContent = null, int? replyToMessageId = null, bool? allowSendingWithoutReply = null, IReplyMarkup? replyMarkup = null, CancellationToken cancellationToken = default)
        {
            return Client.SendContactAsync(ChatId, phoneNumber, firstName, lastName, vCard, disableNotification, protectContent, replyToMessageId, allowSendingWithoutReply, replyMarkup, cancellationToken);
        }

        /// <summary>
        /// Use this method to send phone contacts.
        /// </summary>
        /// <param name="botClient">An instance of <see cref="ITelegramBotClient"/></param>
        /// <param name="chatId">
        /// Unique identifier for the target chat or username of the target channel
        /// (in the format <c>@channelusername</c>)
        /// </param>
        /// <param name="phoneNumber">Contact's phone number</param>
        /// <param name="firstName">Contact's first name</param>
        /// <param name="lastName">Contact's last name</param>
        /// <param name="vCard">Additional data about the contact in the form of a vCard, 0-2048 bytes</param>
        /// <param name="disableNotification">
        /// Sends the message silently. Users will receive a notification with no sound
        /// </param>
        /// <param name="protectContent">Protects the contents of sent messages from forwarding and saving</param>
        /// <param name="replyToMessageId">If the message is a reply, ID of the original message</param>
        /// <param name="allowSendingWithoutReply">
        /// Pass <c>true</c>, if the message should be sent even if the specified replied-to message is not found
        /// </param>
        /// <param name="replyMarkup">
        /// Additional interface options. An <see cref="InlineKeyboardMarkup">inline keyboard</see>,
        /// <see cref="ReplyKeyboardMarkup">custom reply keyboard</see>, instructions to
        /// <see cref="ReplyKeyboardRemove">remove reply keyboard</see> or to
        /// <see cref="ForceReplyMarkup">force a reply</see> from the user
        /// </param>
        /// <param name="cancellationToken">
        /// A cancellation token that can be used by other objects or threads to receive notice of cancellation
        /// </param>
        /// <returns>On success, the sent <see cref="Message"/> is returned.</returns>
        public Task<Message> SendContactAsync(ChatId chatId, string phoneNumber, string firstName, string? lastName = null, string? vCard = null, bool? disableNotification = null, bool? protectContent = null, int? replyToMessageId = null, bool? allowSendingWithoutReply = null, IReplyMarkup? replyMarkup = null, CancellationToken cancellationToken = default)
        {
            return Client.SendContactAsync(chatId, phoneNumber, firstName, lastName, vCard, disableNotification, protectContent, replyToMessageId, allowSendingWithoutReply, replyMarkup, cancellationToken);
        }

        /// <summary>
        /// Use this method to send an animated emoji that will display a random value.
        /// </summary>
        /// <param name="botClient">An instance of <see cref="ITelegramBotClient"/></param>
        /// <param name="chatId">
        /// Unique identifier for the target chat or username of the target channel
        /// (in the format <c>@channelusername</c>)
        /// </param>
        /// <param name="emoji">
        /// Emoji on which the dice throw animation is based. Currently, must be one of <see cref="Emoji.Dice"/>,
        /// <see cref="Emoji.Darts"/>, <see cref="Emoji.Basketball"/>, <see cref="Emoji.Football"/>,
        /// <see cref="Emoji.Bowling"/> or <see cref="Emoji.SlotMachine"/>. Dice can have values 1-6 for
        /// <see cref="Emoji.Dice"/>, <see cref="Emoji.Darts"/> and <see cref="Emoji.Bowling"/>, values 1-5 for
        /// <see cref="Emoji.Basketball"/> and <see cref="Emoji.Football"/>, and values 1-64 for
        /// <see cref="Emoji.SlotMachine"/>. Defauts to <see cref="Emoji.Dice"/>
        /// </param>
        /// <param name="disableNotification">
        /// Sends the message silently. Users will receive a notification with no sound
        /// </param>
        /// <param name="protectContent">Protects the contents of sent messages from forwarding and saving</param>
        /// <param name="replyToMessageId">If the message is a reply, ID of the original message</param>
        /// <param name="allowSendingWithoutReply">
        /// Pass <c>true</c>, if the message should be sent even if the specified replied-to message is not found
        /// </param>
        /// <param name="replyMarkup">
        /// Additional interface options. An <see cref="InlineKeyboardMarkup">inline keyboard</see>,
        /// <see cref="ReplyKeyboardMarkup">custom reply keyboard</see>, instructions to
        /// <see cref="ReplyKeyboardRemove">remove reply keyboard</see> or to
        /// <see cref="ForceReplyMarkup">force a reply</see> from the user
        /// </param>
        /// <param name="cancellationToken">
        /// A cancellation token that can be used by other objects or threads to receive notice of cancellation
        /// </param>
        /// <returns>On success, the sent <see cref="Message"/> is returned.</returns>
        public Task<Message> SendDiceAsync(bool disableNotification = false, bool? protectContent = null, bool? allowSendingWithoutReply = null, int replyToMessageId = 0, IReplyMarkup replyMarkup = null, CancellationToken cancellationToken = default, Emoji? emoji = null)
        {
            return Client.SendDiceAsync(ChatId, emoji, disableNotification, protectContent, replyToMessageId, allowSendingWithoutReply, replyMarkup, cancellationToken);
        }

        /// <summary>
        /// Use this method to send an animated emoji that will display a random value.
        /// </summary>
        /// <param name="botClient">An instance of <see cref="ITelegramBotClient"/></param>
        /// <param name="chatId">
        /// Unique identifier for the target chat or username of the target channel
        /// (in the format <c>@channelusername</c>)
        /// </param>
        /// <param name="emoji">
        /// Emoji on which the dice throw animation is based. Currently, must be one of <see cref="Emoji.Dice"/>,
        /// <see cref="Emoji.Darts"/>, <see cref="Emoji.Basketball"/>, <see cref="Emoji.Football"/>,
        /// <see cref="Emoji.Bowling"/> or <see cref="Emoji.SlotMachine"/>. Dice can have values 1-6 for
        /// <see cref="Emoji.Dice"/>, <see cref="Emoji.Darts"/> and <see cref="Emoji.Bowling"/>, values 1-5 for
        /// <see cref="Emoji.Basketball"/> and <see cref="Emoji.Football"/>, and values 1-64 for
        /// <see cref="Emoji.SlotMachine"/>. Defauts to <see cref="Emoji.Dice"/>
        /// </param>
        /// <param name="disableNotification">
        /// Sends the message silently. Users will receive a notification with no sound
        /// </param>
        /// <param name="protectContent">Protects the contents of sent messages from forwarding and saving</param>
        /// <param name="replyToMessageId">If the message is a reply, ID of the original message</param>
        /// <param name="allowSendingWithoutReply">
        /// Pass <c>true</c>, if the message should be sent even if the specified replied-to message is not found
        /// </param>
        /// <param name="replyMarkup">
        /// Additional interface options. An <see cref="InlineKeyboardMarkup">inline keyboard</see>,
        /// <see cref="ReplyKeyboardMarkup">custom reply keyboard</see>, instructions to
        /// <see cref="ReplyKeyboardRemove">remove reply keyboard</see> or to
        /// <see cref="ForceReplyMarkup">force a reply</see> from the user
        /// </param>
        /// <param name="cancellationToken">
        /// A cancellation token that can be used by other objects or threads to receive notice of cancellation
        /// </param>
        /// <returns>On success, the sent <see cref="Message"/> is returned.</returns>
        public Task<Message> SendDiceAsync(long chatId, bool disableNotification = false, bool? protectContent = null, bool? allowSendingWithoutReply = null, int replyToMessageId = 0, IReplyMarkup replyMarkup = null, CancellationToken cancellationToken = default, Emoji? emoji = null)
        {
            return Client.SendDiceAsync(chatId, emoji, disableNotification, protectContent, replyToMessageId, allowSendingWithoutReply, replyMarkup, cancellationToken);
        }

        /// <summary>
        /// Use this method to send general files. Bots can currently send files of any type of up to 50 MB in size,
        /// this limit may be changed in the future.
        /// </summary>
        /// <param name="botClient">An instance of <see cref="ITelegramBotClient"/></param>
        /// <param name="chatId">
        /// Unique identifier for the target chat or username of the target channel
        /// (in the format <c>@channelusername</c>)
        /// </param>
        /// <param name="document">
        /// File to send. Pass a <see cref="InputTelegramFile.FileId"/> as String to send a file that exists on the
        /// Telegram servers (recommended), pass an HTTP URL as a String for Telegram to get a file from the Internet,
        /// or upload a new one using multipart/form-data
        /// </param>
        /// <param name="thumb">
        /// Thumbnail of the file sent; can be ignored if thumbnail generation for the file is supported server-side.
        /// The thumbnail should be in JPEG format and less than 200 kB in size. A thumbnail's width and height should
        /// not exceed 320. Ignored if the file is not uploaded using multipart/form-data. Thumbnails can't be reused
        /// and can be only uploaded as a new file, so you can pass "attach://&lt;file_attach_name&gt;" if the
        /// thumbnail was uploaded using multipart/form-data under &lt;file_attach_name&gt;
        /// </param>
        /// <param name="caption">
        /// Document caption (may also be used when resending documents by file_id), 0-1024 characters after
        /// entities parsing
        /// </param>
        /// <param name="parseMode">
        /// Mode for parsing entities in the new caption. See
        /// <a href="https://core.telegram.org/bots/api#formatting-options">formatting</a> options for
        /// more details
        /// </param>
        /// <param name="captionEntities">
        /// List of special entities that appear in the caption, which can be specified instead
        /// of <see cref="ParseMode"/>
        /// </param>
        /// <param name="disableContentTypeDetection">
        /// Disables automatic server-side content type detection for files uploaded using multipart/form-data
        /// </param>
        /// <param name="disableNotification">
        /// Sends the message silently. Users will receive a notification with no sound
        /// </param>
        /// <param name="protectContent">Protects the contents of sent messages from forwarding and saving</param>
        /// <param name="replyToMessageId">If the message is a reply, ID of the original message</param>
        /// <param name="allowSendingWithoutReply">
        /// Pass <c>true</c>, if the message should be sent even if the specified replied-to message is not found
        /// </param>
        /// <param name="replyMarkup">
        /// Additional interface options. An <see cref="InlineKeyboardMarkup">inline keyboard</see>,
        /// <see cref="ReplyKeyboardMarkup">custom reply keyboard</see>, instructions to
        /// <see cref="ReplyKeyboardRemove">remove reply keyboard</see> or to
        /// <see cref="ForceReplyMarkup">force a reply</see> from the user
        /// </param>
        /// <param name="cancellationToken">
        /// A cancellation token that can be used by other objects or threads to receive notice of cancellation
        /// </param>
        /// <returns>On success, the sent <see cref="Message"/> is returned.</returns>
        public Task<Message> SendDocumentAsync(InputOnlineFile document, string caption = null, bool? disableContentTypeDetection = null, bool? protectContent = null, bool? allowSendingWithoutReply = null, ParseMode parseMode = 0, bool disableNotification = false, int replyToMessageId = 0, IReplyMarkup replyMarkup = null, CancellationToken cancellationToken = default, InputMedia thumb = null)
        {
            return Client.SendDocumentAsync(ChatId, document, thumb, caption, parseMode, null, disableContentTypeDetection, disableNotification, protectContent, replyToMessageId, allowSendingWithoutReply, replyMarkup, cancellationToken);
        }

        /// <summary>
        /// Use this method to send general files. Bots can currently send files of any type of up to 50 MB in size,
        /// this limit may be changed in the future.
        /// </summary>
        /// <param name="botClient">An instance of <see cref="ITelegramBotClient"/></param>
        /// <param name="chatId">
        /// Unique identifier for the target chat or username of the target channel
        /// (in the format <c>@channelusername</c>)
        /// </param>
        /// <param name="document">
        /// File to send. Pass a <see cref="InputTelegramFile.FileId"/> as String to send a file that exists on the
        /// Telegram servers (recommended), pass an HTTP URL as a String for Telegram to get a file from the Internet,
        /// or upload a new one using multipart/form-data
        /// </param>
        /// <param name="thumb">
        /// Thumbnail of the file sent; can be ignored if thumbnail generation for the file is supported server-side.
        /// The thumbnail should be in JPEG format and less than 200 kB in size. A thumbnail's width and height should
        /// not exceed 320. Ignored if the file is not uploaded using multipart/form-data. Thumbnails can't be reused
        /// and can be only uploaded as a new file, so you can pass "attach://&lt;file_attach_name&gt;" if the
        /// thumbnail was uploaded using multipart/form-data under &lt;file_attach_name&gt;
        /// </param>
        /// <param name="caption">
        /// Document caption (may also be used when resending documents by file_id), 0-1024 characters after
        /// entities parsing
        /// </param>
        /// <param name="parseMode">
        /// Mode for parsing entities in the new caption. See
        /// <a href="https://core.telegram.org/bots/api#formatting-options">formatting</a> options for
        /// more details
        /// </param>
        /// <param name="captionEntities">
        /// List of special entities that appear in the caption, which can be specified instead
        /// of <see cref="ParseMode"/>
        /// </param>
        /// <param name="disableContentTypeDetection">
        /// Disables automatic server-side content type detection for files uploaded using multipart/form-data
        /// </param>
        /// <param name="disableNotification">
        /// Sends the message silently. Users will receive a notification with no sound
        /// </param>
        /// <param name="protectContent">Protects the contents of sent messages from forwarding and saving</param>
        /// <param name="replyToMessageId">If the message is a reply, ID of the original message</param>
        /// <param name="allowSendingWithoutReply">
        /// Pass <c>true</c>, if the message should be sent even if the specified replied-to message is not found
        /// </param>
        /// <param name="replyMarkup">
        /// Additional interface options. An <see cref="InlineKeyboardMarkup">inline keyboard</see>,
        /// <see cref="ReplyKeyboardMarkup">custom reply keyboard</see>, instructions to
        /// <see cref="ReplyKeyboardRemove">remove reply keyboard</see> or to
        /// <see cref="ForceReplyMarkup">force a reply</see> from the user
        /// </param>
        /// <param name="cancellationToken">
        /// A cancellation token that can be used by other objects or threads to receive notice of cancellation
        /// </param>
        /// <returns>On success, the sent <see cref="Message"/> is returned.</returns>
        public Task<Message> SendDocumentAsync(long chatId, InputOnlineFile document, string caption = null, bool? disableContentTypeDetection = null, bool? protectContent = null, bool? allowSendingWithoutReply = null, ParseMode parseMode = 0, bool disableNotification = false, int replyToMessageId = 0, IReplyMarkup replyMarkup = null, CancellationToken cancellationToken = default, InputMedia thumb = null)
        {
            return Client.SendDocumentAsync(chatId, document, thumb, caption, parseMode, null, disableContentTypeDetection, disableNotification, protectContent, replyToMessageId, allowSendingWithoutReply, replyMarkup, cancellationToken);
        }

        /// <summary>
        /// Use this method to send a game.
        /// </summary>
        /// <param name="botClient">An instance of <see cref="ITelegramBotClient"/></param>
        /// <param name="chatId">Unique identifier for the target chat</param>
        /// <param name="gameShortName">
        /// Short name of the game, serves as the unique identifier for the game. Set up your games via
        /// <a href="https://t.me/botfather">@Botfather</a>
        /// </param>
        /// <param name="disableNotification">
        /// Sends the message silently. Users will receive a notification with no sound
        /// </param>
        /// <param name="protectContent">Protects the contents of sent messages from forwarding and saving</param>
        /// <param name="replyToMessageId">If the message is a reply, ID of the original message</param>
        /// <param name="allowSendingWithoutReply">
        /// Pass <c>true</c>, if the message should be sent even if the specified replied-to message is not found
        /// </param>
        /// <param name="replyMarkup">
        /// Additional interface options. An <see cref="InlineKeyboardMarkup">inline keyboard</see>,
        /// <see cref="ReplyKeyboardMarkup">custom reply keyboard</see>, instructions to
        /// <see cref="ReplyKeyboardRemove">remove reply keyboard</see> or to
        /// <see cref="ForceReplyMarkup">force a reply</see> from the user
        /// </param>
        /// <param name="cancellationToken">
        /// A cancellation token that can be used by other objects or threads to receive notice of cancellation
        /// </param>
        /// <returns>On success, the sent <see cref="Message"/> is returned.</returns>
        public Task<Message> SendGameAsync(string gameShortName, bool disableNotification = false, bool? protectContent = null, bool? allowSendingWithoutReply = null, int replyToMessageId = 0, InlineKeyboardMarkup replyMarkup = null, CancellationToken cancellationToken = default)
        {
            return Client.SendGameAsync(ChatId, gameShortName, disableNotification, protectContent, replyToMessageId, allowSendingWithoutReply, replyMarkup, cancellationToken);
        }

        /// <summary>
        /// Use this method to send a game.
        /// </summary>
        /// <param name="botClient">An instance of <see cref="ITelegramBotClient"/></param>
        /// <param name="chatId">Unique identifier for the target chat</param>
        /// <param name="gameShortName">
        /// Short name of the game, serves as the unique identifier for the game. Set up your games via
        /// <a href="https://t.me/botfather">@Botfather</a>
        /// </param>
        /// <param name="disableNotification">
        /// Sends the message silently. Users will receive a notification with no sound
        /// </param>
        /// <param name="protectContent">Protects the contents of sent messages from forwarding and saving</param>
        /// <param name="replyToMessageId">If the message is a reply, ID of the original message</param>
        /// <param name="allowSendingWithoutReply">
        /// Pass <c>true</c>, if the message should be sent even if the specified replied-to message is not found
        /// </param>
        /// <param name="replyMarkup">
        /// Additional interface options. An <see cref="InlineKeyboardMarkup">inline keyboard</see>,
        /// <see cref="ReplyKeyboardMarkup">custom reply keyboard</see>, instructions to
        /// <see cref="ReplyKeyboardRemove">remove reply keyboard</see> or to
        /// <see cref="ForceReplyMarkup">force a reply</see> from the user
        /// </param>
        /// <param name="cancellationToken">
        /// A cancellation token that can be used by other objects or threads to receive notice of cancellation
        /// </param>
        /// <returns>On success, the sent <see cref="Message"/> is returned.</returns>
        public Task<Message> SendGameAsync(long chatId, string gameShortName, bool disableNotification = false, bool? protectContent = null, bool? allowSendingWithoutReply = null, int replyToMessageId = 0, InlineKeyboardMarkup replyMarkup = null, CancellationToken cancellationToken = default)
        {
            return Client.SendGameAsync(chatId, gameShortName, disableNotification, protectContent, replyToMessageId, allowSendingWithoutReply, replyMarkup, cancellationToken);
        }

        /// <summary>
        /// Use this method to send invoices.
        /// </summary>
        /// <param name="botClient">An instance of <see cref="ITelegramBotClient"/></param>
        /// <param name="chatId">
        /// Unique identifier for the target chat or username of the target channel
        /// (in the format <c>@channelusername</c>)
        /// </param>
        /// <param name="title">Product name, 1-32 characters</param>
        /// <param name="description">Product description, 1-255 characters</param>
        /// <param name="payload">
        /// Bot-defined invoice payload, 1-128 bytes. This will not be displayed to the user,
        /// use for your internal processes
        /// </param>
        /// <param name="providerToken">
        /// Payments provider token, obtained via <a href="https://t.me/botfather">@Botfather</a>
        /// </param>
        /// <param name="currency">
        /// Three-letter ISO 4217 currency code, see
        /// <a href="https://core.telegram.org/bots/payments#supported-currencies">more on currencies</a>
        /// </param>
        /// <param name="prices">
        /// Price breakdown, a list of components (e.g. product price, tax, discount, delivery cost, delivery tax,
        /// bonus, etc.)
        /// </param>
        /// <param name="maxTipAmount">
        /// The maximum accepted amount for tips in the smallest units of the currency (integer, not float/double).
        /// For example, for a maximum tip of <c>US$ 1.45</c> pass <c><paramref name="maxTipAmount"/> = 145</c>.
        /// See the <i>exp</i> parameter in
        /// <a href="https://core.telegram.org/bots/payments/currencies.json">currencies.json</a>, it shows the
        /// number of digits past the decimal point for each currency (2 for the majority of currencies).
        /// Defaults to 0
        /// </param>
        /// <param name="suggestedTipAmounts">
        /// An array of suggested amounts of tips in the <i>smallest units</i> of the currency (integer,
        /// <b>not</b> float/double). At most 4 suggested tip amounts can be specified. The suggested tip amounts must
        /// be positive, passed in a strictly increased order and must not exceed <paramref name="maxTipAmount"/>
        /// </param>
        /// <param name="startParameter">
        /// Unique deep-linking parameter. If left empty, <b>forwarded copies</b> of the sent message will have
        /// a <i>Pay</i> button, allowing multiple users to pay directly from the forwarded message, using the same
        /// invoice. If non-empty, forwarded copies of the sent message will have a <i>URL</i> button with a deep
        /// link to the bot (instead of a <i>Pay</i> button), with the value used as the start parameter
        /// </param>
        /// <param name="providerData">
        /// A JSON-serialized data about the invoice, which will be shared with the payment provider. A detailed
        /// description of required fields should be provided by the payment provide
        /// </param>
        /// <param name="photoUrl">
        /// URL of the product photo for the invoice. Can be a photo of the goods or a marketing image for a service.
        /// People like it better when they see what they are paying for
        /// </param>
        /// <param name="photoSize">Photo size</param>
        /// <param name="photoWidth">Photo width</param>
        /// <param name="photoHeight">Photo height</param>
        /// <param name="needName">Pass <c>true</c>, if you require the user's full name to complete the order</param>
        /// <param name="needPhoneNumber">
        /// Pass <c>true</c>, if you require the user's phone number to complete the order
        /// </param>
        /// <param name="needEmail">Pass <c>true</c>, if you require the user's email to complete the order</param>
        /// <param name="needShippingAddress">
        /// Pass <c>true</c>, if you require the user's shipping address to complete the order
        /// </param>
        /// <param name="sendPhoneNumberToProvider">
        /// Pass <c>true</c>, if user's phone number should be sent to provider
        /// </param>
        /// <param name="sendEmailToProvider">
        /// Pass <c>true</c>, if user's email address should be sent to provider
        /// </param>
        /// <param name="isFlexible">Pass <c>true</c>, if the final price depends on the shipping method</param>
        /// <param name="disableNotification">
        /// Sends the message silently. Users will receive a notification with no sound
        /// </param>
        /// <param name="protectContent">Protects the contents of sent messages from forwarding and saving</param>
        /// <param name="replyToMessageId">If the message is a reply, ID of the original message</param>
        /// <param name="allowSendingWithoutReply">
        /// Pass <c>true</c>, if the message should be sent even if the specified replied-to message is not found
        /// </param>
        /// <param name="replyMarkup">
        /// Additional interface options. An <see cref="InlineKeyboardMarkup">inline keyboard</see>,
        /// <see cref="ReplyKeyboardMarkup">custom reply keyboard</see>, instructions to
        /// <see cref="ReplyKeyboardRemove">remove reply keyboard</see> or to
        /// <see cref="ForceReplyMarkup">force a reply</see> from the user
        /// </param>
        /// <param name="cancellationToken">
        /// A cancellation token that can be used by other objects or threads to receive notice of cancellation
        /// </param>
        /// <returns>On success, the sent <see cref="Message"/> is returned.</returns>
        public Task<Message> SendInvoiceAsync(
        string title,
        string description,
        string payload,
        string providerToken,
        string currency,
        IEnumerable<LabeledPrice> prices,
        int? maxTipAmount = default,
        IEnumerable<int>? suggestedTipAmounts = default,
        string? startParameter = default,
        string? providerData = default,
        string? photoUrl = default,
        int? photoSize = default,
        int? photoWidth = default,
        int? photoHeight = default,
        bool? needName = default,
        bool? needPhoneNumber = default,
        bool? needEmail = default,
        bool? needShippingAddress = default,
        bool? sendPhoneNumberToProvider = default,
        bool? sendEmailToProvider = default,
        bool? isFlexible = default,
        bool? disableNotification = default,
        bool? protectContent = default,
        int? replyToMessageId = default,
        bool? allowSendingWithoutReply = default,
        InlineKeyboardMarkup? replyMarkup = default,
        CancellationToken cancellationToken = default
    )
        {
            return Client.SendInvoiceAsync(ChatId,
                title,
                description,
                payload,
                providerToken,
                currency,
                prices,
                maxTipAmount,
                suggestedTipAmounts,
                startParameter,
                providerData,
                photoUrl,
                photoSize,
                photoWidth,
                photoHeight,
                needName,
                needPhoneNumber,
                needEmail,
                needShippingAddress,
                sendPhoneNumberToProvider,
                sendEmailToProvider,
                isFlexible,
                disableNotification,
                protectContent,
                replyToMessageId,
                allowSendingWithoutReply,
                replyMarkup,
                cancellationToken);
        }

        /// <summary>
        /// Use this method to send invoices.
        /// </summary>
        /// <param name="botClient">An instance of <see cref="ITelegramBotClient"/></param>
        /// <param name="chatId">
        /// Unique identifier for the target chat or username of the target channel
        /// (in the format <c>@channelusername</c>)
        /// </param>
        /// <param name="title">Product name, 1-32 characters</param>
        /// <param name="description">Product description, 1-255 characters</param>
        /// <param name="payload">
        /// Bot-defined invoice payload, 1-128 bytes. This will not be displayed to the user,
        /// use for your internal processes
        /// </param>
        /// <param name="providerToken">
        /// Payments provider token, obtained via <a href="https://t.me/botfather">@Botfather</a>
        /// </param>
        /// <param name="currency">
        /// Three-letter ISO 4217 currency code, see
        /// <a href="https://core.telegram.org/bots/payments#supported-currencies">more on currencies</a>
        /// </param>
        /// <param name="prices">
        /// Price breakdown, a list of components (e.g. product price, tax, discount, delivery cost, delivery tax,
        /// bonus, etc.)
        /// </param>
        /// <param name="maxTipAmount">
        /// The maximum accepted amount for tips in the smallest units of the currency (integer, not float/double).
        /// For example, for a maximum tip of <c>US$ 1.45</c> pass <c><paramref name="maxTipAmount"/> = 145</c>.
        /// See the <i>exp</i> parameter in
        /// <a href="https://core.telegram.org/bots/payments/currencies.json">currencies.json</a>, it shows the
        /// number of digits past the decimal point for each currency (2 for the majority of currencies).
        /// Defaults to 0
        /// </param>
        /// <param name="suggestedTipAmounts">
        /// An array of suggested amounts of tips in the <i>smallest units</i> of the currency (integer,
        /// <b>not</b> float/double). At most 4 suggested tip amounts can be specified. The suggested tip amounts must
        /// be positive, passed in a strictly increased order and must not exceed <paramref name="maxTipAmount"/>
        /// </param>
        /// <param name="startParameter">
        /// Unique deep-linking parameter. If left empty, <b>forwarded copies</b> of the sent message will have
        /// a <i>Pay</i> button, allowing multiple users to pay directly from the forwarded message, using the same
        /// invoice. If non-empty, forwarded copies of the sent message will have a <i>URL</i> button with a deep
        /// link to the bot (instead of a <i>Pay</i> button), with the value used as the start parameter
        /// </param>
        /// <param name="providerData">
        /// A JSON-serialized data about the invoice, which will be shared with the payment provider. A detailed
        /// description of required fields should be provided by the payment provide
        /// </param>
        /// <param name="photoUrl">
        /// URL of the product photo for the invoice. Can be a photo of the goods or a marketing image for a service.
        /// People like it better when they see what they are paying for
        /// </param>
        /// <param name="photoSize">Photo size</param>
        /// <param name="photoWidth">Photo width</param>
        /// <param name="photoHeight">Photo height</param>
        /// <param name="needName">Pass <c>true</c>, if you require the user's full name to complete the order</param>
        /// <param name="needPhoneNumber">
        /// Pass <c>true</c>, if you require the user's phone number to complete the order
        /// </param>
        /// <param name="needEmail">Pass <c>true</c>, if you require the user's email to complete the order</param>
        /// <param name="needShippingAddress">
        /// Pass <c>true</c>, if you require the user's shipping address to complete the order
        /// </param>
        /// <param name="sendPhoneNumberToProvider">
        /// Pass <c>true</c>, if user's phone number should be sent to provider
        /// </param>
        /// <param name="sendEmailToProvider">
        /// Pass <c>true</c>, if user's email address should be sent to provider
        /// </param>
        /// <param name="isFlexible">Pass <c>true</c>, if the final price depends on the shipping method</param>
        /// <param name="disableNotification">
        /// Sends the message silently. Users will receive a notification with no sound
        /// </param>
        /// <param name="protectContent">Protects the contents of sent messages from forwarding and saving</param>
        /// <param name="replyToMessageId">If the message is a reply, ID of the original message</param>
        /// <param name="allowSendingWithoutReply">
        /// Pass <c>true</c>, if the message should be sent even if the specified replied-to message is not found
        /// </param>
        /// <param name="replyMarkup">
        /// Additional interface options. An <see cref="InlineKeyboardMarkup">inline keyboard</see>,
        /// <see cref="ReplyKeyboardMarkup">custom reply keyboard</see>, instructions to
        /// <see cref="ReplyKeyboardRemove">remove reply keyboard</see> or to
        /// <see cref="ForceReplyMarkup">force a reply</see> from the user
        /// </param>
        /// <param name="cancellationToken">
        /// A cancellation token that can be used by other objects or threads to receive notice of cancellation
        /// </param>
        /// <returns>On success, the sent <see cref="Message"/> is returned.</returns>

        public Task<Message> SendInvoiceAsync(
        long chatId,
        string title,
        string description,
        string payload,
        string providerToken,
        string currency,
        IEnumerable<LabeledPrice> prices,
        int? maxTipAmount = default,
        IEnumerable<int>? suggestedTipAmounts = default,
        string? startParameter = default,
        string? providerData = default,
        string? photoUrl = default,
        int? photoSize = default,
        int? photoWidth = default,
        int? photoHeight = default,
        bool? needName = default,
        bool? needPhoneNumber = default,
        bool? needEmail = default,
        bool? needShippingAddress = default,
        bool? sendPhoneNumberToProvider = default,
        bool? sendEmailToProvider = default,
        bool? isFlexible = default,
        bool? disableNotification = default,
        bool? protectContent = default,
        int? replyToMessageId = default,
        bool? allowSendingWithoutReply = default,
        InlineKeyboardMarkup? replyMarkup = default,
        CancellationToken cancellationToken = default
    )
        {
            return Client.SendInvoiceAsync(chatId,
                title,
                description,
                payload,
                providerToken,
                currency,
                prices,
                maxTipAmount,
                suggestedTipAmounts,
                startParameter,
                providerData,
                photoUrl,
                photoSize,
                photoWidth,
                photoHeight,
                needName,
                needPhoneNumber,
                needEmail,
                needShippingAddress,
                sendPhoneNumberToProvider,
                sendEmailToProvider,
                isFlexible,
                disableNotification,
                protectContent,
                replyToMessageId,
                allowSendingWithoutReply,
                replyMarkup,
                cancellationToken);
        }

        /// <summary>
        /// Use this method to send point on the map.
        /// </summary>
        /// <param name="botClient">An instance of <see cref="ITelegramBotClient"/></param>
        /// <param name="chatId">
        /// Unique identifier for the target chat or username of the target channel
        /// (in the format <c>@channelusername</c>)
        /// </param>
        /// <param name="latitude">Latitude of location</param>
        /// <param name="longitude">Longitude of location</param>
        /// <param name="livePeriod">
        /// Period in seconds for which the location will be updated, should be between 60 and 86400
        /// </param>
        /// <param name="heading">
        /// For live locations, a direction in which the user is moving, in degrees. Must be between 1 and 360
        /// if specified
        /// </param>
        /// <param name="proximityAlertRadius">
        /// For live locations, a maximum distance for proximity alerts about approaching another chat member,
        /// in meters. Must be between 1 and 100000 if specified
        /// </param>
        /// <param name="disableNotification">
        /// Sends the message silently. Users will receive a notification with no sound
        /// </param>
        /// <param name="protectContent">Protects the contents of sent messages from forwarding and saving</param>
        /// <param name="replyToMessageId">If the message is a reply, ID of the original message</param>
        /// <param name="allowSendingWithoutReply">
        /// Pass <c>true</c>, if the message should be sent even if the specified replied-to message is not found
        /// </param>
        /// <param name="replyMarkup">
        /// Additional interface options. An <see cref="InlineKeyboardMarkup">inline keyboard</see>,
        /// <see cref="ReplyKeyboardMarkup">custom reply keyboard</see>, instructions to
        /// <see cref="ReplyKeyboardRemove">remove reply keyboard</see> or to
        /// <see cref="ForceReplyMarkup">force a reply</see> from the user
        /// </param>
        /// <param name="cancellationToken">
        /// A cancellation token that can be used by other objects or threads to receive notice of cancellation
        /// </param>
        /// <returns>On success, the sent <see cref="Message"/> is returned.</returns>
        public Task<Message> SendLocationAsync(
            double latitude,
            double longitude,
            int? livePeriod = default,
            int? heading = default,
            int? proximityAlertRadius = default,
            bool? disableNotification = default,
            bool? protectContent = default,
            int? replyToMessageId = default,
            bool? allowSendingWithoutReply = default,
            IReplyMarkup? replyMarkup = default,
            CancellationToken cancellationToken = default)
        {
            return Client.SendLocationAsync(ChatId,
                latitude,
                longitude,
                livePeriod,
                heading,
                proximityAlertRadius,
                disableNotification,
                protectContent,
                replyToMessageId,
                allowSendingWithoutReply,
                replyMarkup,
                cancellationToken);
        }

        /// <summary>
        /// Use this method to send point on the map.
        /// </summary>
        /// <param name="botClient">An instance of <see cref="ITelegramBotClient"/></param>
        /// <param name="chatId">
        /// Unique identifier for the target chat or username of the target channel
        /// (in the format <c>@channelusername</c>)
        /// </param>
        /// <param name="latitude">Latitude of location</param>
        /// <param name="longitude">Longitude of location</param>
        /// <param name="livePeriod">
        /// Period in seconds for which the location will be updated, should be between 60 and 86400
        /// </param>
        /// <param name="heading">
        /// For live locations, a direction in which the user is moving, in degrees. Must be between 1 and 360
        /// if specified
        /// </param>
        /// <param name="proximityAlertRadius">
        /// For live locations, a maximum distance for proximity alerts about approaching another chat member,
        /// in meters. Must be between 1 and 100000 if specified
        /// </param>
        /// <param name="disableNotification">
        /// Sends the message silently. Users will receive a notification with no sound
        /// </param>
        /// <param name="protectContent">Protects the contents of sent messages from forwarding and saving</param>
        /// <param name="replyToMessageId">If the message is a reply, ID of the original message</param>
        /// <param name="allowSendingWithoutReply">
        /// Pass <c>true</c>, if the message should be sent even if the specified replied-to message is not found
        /// </param>
        /// <param name="replyMarkup">
        /// Additional interface options. An <see cref="InlineKeyboardMarkup">inline keyboard</see>,
        /// <see cref="ReplyKeyboardMarkup">custom reply keyboard</see>, instructions to
        /// <see cref="ReplyKeyboardRemove">remove reply keyboard</see> or to
        /// <see cref="ForceReplyMarkup">force a reply</see> from the user
        /// </param>
        /// <param name="cancellationToken">
        /// A cancellation token that can be used by other objects or threads to receive notice of cancellation
        /// </param>
        /// <returns>On success, the sent <see cref="Message"/> is returned.</returns>
        public Task<Message> SendLocationAsync(
            long chatId,
            double latitude,
            double longitude,
            int? livePeriod = default,
            int? heading = default,
            int? proximityAlertRadius = default,
            bool? disableNotification = default,
            bool? protectContent = default,
            int? replyToMessageId = default,
            bool? allowSendingWithoutReply = default,
            IReplyMarkup? replyMarkup = default,
            CancellationToken cancellationToken = default)
        {
            return Client.SendLocationAsync(chatId,
                latitude,
                longitude,
                livePeriod,
                heading,
                proximityAlertRadius,
                disableNotification,
                protectContent,
                replyToMessageId,
                allowSendingWithoutReply,
                replyMarkup,
                cancellationToken);
        }

        /// <summary>
        /// Use this method to send a group of photos, videos, documents or audios as an album. Documents and audio
        /// files can be only grouped in an album with messages of the same type.
        /// </summary>
        /// <param name="botClient">An instance of <see cref="ITelegramBotClient"/></param>
        /// <param name="chatId">
        /// Unique identifier for the target chat or username of the target channel
        /// (in the format <c>@channelusername</c>)
        /// </param>
        /// <param name="media">An array describing messages to be sent, must include 2-10 items</param>
        /// <param name="disableNotification">
        /// Sends the message silently. Users will receive a notification with no sound
        /// </param>
        /// <param name="protectContent">Protects the contents of sent messages from forwarding and saving</param>
        /// <param name="replyToMessageId">If the message is a reply, ID of the original message</param>
        /// <param name="allowSendingWithoutReply">
        /// Pass <c>true</c>, if the message should be sent even if the specified replied-to message is not found
        /// </param>
        /// <param name="cancellationToken">
        /// A cancellation token that can be used by other objects or threads to receive notice of cancellation
        /// </param>
        /// <returns>On success, an array of <see cref="Message"/>s that were sent is returned.</returns>
        public Task<Message[]> SendMediaGroupAsync(
            IEnumerable<IAlbumInputMedia> media,
            bool? disableNotification = default,
            bool? protectContent = default,
            int? replyToMessageId = default,
            bool? allowSendingWithoutReply = default,
            CancellationToken cancellationToken = default)
        {
            return Client.SendMediaGroupAsync(ChatId, media, disableNotification, protectContent, replyToMessageId, allowSendingWithoutReply, cancellationToken);
        }

        /// <summary>
        /// Use this method to send a group of photos, videos, documents or audios as an album. Documents and audio
        /// files can be only grouped in an album with messages of the same type.
        /// </summary>
        /// <param name="botClient">An instance of <see cref="ITelegramBotClient"/></param>
        /// <param name="chatId">
        /// Unique identifier for the target chat or username of the target channel
        /// (in the format <c>@channelusername</c>)
        /// </param>
        /// <param name="media">An array describing messages to be sent, must include 2-10 items</param>
        /// <param name="disableNotification">
        /// Sends the message silently. Users will receive a notification with no sound
        /// </param>
        /// <param name="protectContent">Protects the contents of sent messages from forwarding and saving</param>
        /// <param name="replyToMessageId">If the message is a reply, ID of the original message</param>
        /// <param name="allowSendingWithoutReply">
        /// Pass <c>true</c>, if the message should be sent even if the specified replied-to message is not found
        /// </param>
        /// <param name="cancellationToken">
        /// A cancellation token that can be used by other objects or threads to receive notice of cancellation
        /// </param>
        /// <returns>On success, an array of <see cref="Message"/>s that were sent is returned.</returns>
        public Task<Message[]> SendMediaGroupAsync(
            long chatId,
            IEnumerable<IAlbumInputMedia> media,
            bool? disableNotification = default,
            bool? protectContent = default,
            int? replyToMessageId = default,
            bool? allowSendingWithoutReply = default,
            CancellationToken cancellationToken = default)
        {
            return Client.SendMediaGroupAsync(chatId, media, disableNotification, protectContent, replyToMessageId, allowSendingWithoutReply, cancellationToken);
        }

        /// <summary>
        /// Use this method to send photos.
        /// </summary>
        /// <param name="botClient">An instance of <see cref="ITelegramBotClient"/></param>
        /// <param name="chatId">
        /// Unique identifier for the target chat or username of the target channel
        /// (in the format <c>@channelusername</c>)
        /// </param>
        /// <param name="photo">
        /// Photo to send. Pass a <see cref="InputTelegramFile.FileId"/> as String to send a photo that exists on
        /// the Telegram servers (recommended), pass an HTTP URL as a String for Telegram to get a photo from
        /// the Internet, or upload a new photo using multipart/form-data. The photo must be at most 10 MB in size.
        /// The photo's width and height must not exceed 10000 in total. Width and height ratio must be at most 20
        /// </param>
        /// <param name="caption">
        /// Photo caption (may also be used when resending photos by <see cref="InputTelegramFile.FileId"/>),
        /// 0-1024 characters after entities parsing
        /// </param>
        /// <param name="parseMode">
        /// Mode for parsing entities in the new caption. See
        /// <a href="https://core.telegram.org/bots/api#formatting-options">formatting</a> options for
        /// more details
        /// </param>
        /// <param name="captionEntities">
        /// List of special entities that appear in the caption, which can be specified instead
        /// of <see cref="ParseMode"/>
        /// </param>
        /// <param name="disableNotification">
        /// Sends the message silently. Users will receive a notification with no sound
        /// </param>
        /// <param name="protectContent">Protects the contents of sent messages from forwarding and saving</param>
        /// <param name="replyToMessageId">If the message is a reply, ID of the original message</param>
        /// <param name="allowSendingWithoutReply">
        /// Pass <c>true</c>, if the message should be sent even if the specified replied-to message is not found
        /// </param>
        /// <param name="replyMarkup">
        /// Additional interface options. An <see cref="InlineKeyboardMarkup">inline keyboard</see>,
        /// <see cref="ReplyKeyboardMarkup">custom reply keyboard</see>, instructions to
        /// <see cref="ReplyKeyboardRemove">remove reply keyboard</see> or to
        /// <see cref="ForceReplyMarkup">force a reply</see> from the user
        /// </param>
        /// <param name="cancellationToken">
        /// A cancellation token that can be used by other objects or threads to receive notice of cancellation
        /// </param>
        /// <returns>On success, the sent <see cref="Message"/> is returned.</returns>
        public Task<Message> SendPhotoAsync(
            InputOnlineFile photo,
            string? caption = default,
            ParseMode? parseMode = default,
            IEnumerable<MessageEntity>? captionEntities = default,
            bool? disableNotification = default,
            bool? protectContent = default,
            int? replyToMessageId = default,
            bool? allowSendingWithoutReply = default,
            IReplyMarkup? replyMarkup = default,
            CancellationToken cancellationToken = default)
        {
            return Client.SendPhotoAsync(ChatId, photo, caption, parseMode, captionEntities, disableNotification, protectContent, replyToMessageId, allowSendingWithoutReply, replyMarkup, cancellationToken);
        }

        /// <summary>
        /// Use this method to send photos.
        /// </summary>
        /// <param name="botClient">An instance of <see cref="ITelegramBotClient"/></param>
        /// <param name="chatId">
        /// Unique identifier for the target chat or username of the target channel
        /// (in the format <c>@channelusername</c>)
        /// </param>
        /// <param name="photo">
        /// Photo to send. Pass a <see cref="InputTelegramFile.FileId"/> as String to send a photo that exists on
        /// the Telegram servers (recommended), pass an HTTP URL as a String for Telegram to get a photo from
        /// the Internet, or upload a new photo using multipart/form-data. The photo must be at most 10 MB in size.
        /// The photo's width and height must not exceed 10000 in total. Width and height ratio must be at most 20
        /// </param>
        /// <param name="caption">
        /// Photo caption (may also be used when resending photos by <see cref="InputTelegramFile.FileId"/>),
        /// 0-1024 characters after entities parsing
        /// </param>
        /// <param name="parseMode">
        /// Mode for parsing entities in the new caption. See
        /// <a href="https://core.telegram.org/bots/api#formatting-options">formatting</a> options for
        /// more details
        /// </param>
        /// <param name="captionEntities">
        /// List of special entities that appear in the caption, which can be specified instead
        /// of <see cref="ParseMode"/>
        /// </param>
        /// <param name="disableNotification">
        /// Sends the message silently. Users will receive a notification with no sound
        /// </param>
        /// <param name="protectContent">Protects the contents of sent messages from forwarding and saving</param>
        /// <param name="replyToMessageId">If the message is a reply, ID of the original message</param>
        /// <param name="allowSendingWithoutReply">
        /// Pass <c>true</c>, if the message should be sent even if the specified replied-to message is not found
        /// </param>
        /// <param name="replyMarkup">
        /// Additional interface options. An <see cref="InlineKeyboardMarkup">inline keyboard</see>,
        /// <see cref="ReplyKeyboardMarkup">custom reply keyboard</see>, instructions to
        /// <see cref="ReplyKeyboardRemove">remove reply keyboard</see> or to
        /// <see cref="ForceReplyMarkup">force a reply</see> from the user
        /// </param>
        /// <param name="cancellationToken">
        /// A cancellation token that can be used by other objects or threads to receive notice of cancellation
        /// </param>
        /// <returns>On success, the sent <see cref="Message"/> is returned.</returns>
        public Task<Message> SendPhotoAsync(
            ChatId chatId,
            InputOnlineFile photo,
            string? caption = default,
            ParseMode? parseMode = default,
            IEnumerable<MessageEntity>? captionEntities = default,
            bool? disableNotification = default,
            bool? protectContent = default,
            int? replyToMessageId = default,
            bool? allowSendingWithoutReply = default,
            IReplyMarkup? replyMarkup = default,
            CancellationToken cancellationToken = default)
        {
            return Client.SendPhotoAsync(chatId, photo, caption, parseMode, captionEntities, disableNotification, protectContent, replyToMessageId, allowSendingWithoutReply, replyMarkup, cancellationToken);
        }

        /// <summary>
        /// Use this method to send a native poll.
        /// </summary>
        /// <param name="botClient">An instance of <see cref="ITelegramBotClient"/></param>
        /// <param name="chatId">
        /// Unique identifier for the target chat or username of the target channel
        /// (in the format <c>@channelusername</c>)
        /// </param>
        /// <param name="question">Poll question, 1-300 characters</param>
        /// <param name="options">A list of answer options, 2-10 strings 1-100 characters each</param>
        /// <param name="isAnonymous"><c>true</c>, if the poll needs to be anonymous, defaults to <c>true</c></param>
        /// <param name="type">
        /// Poll type, <see cref="PollType.Quiz"/> or <see cref="PollType.Regular"/>,
        /// defaults to <see cref="PollType.Regular"/>
        /// </param>
        /// <param name="allowsMultipleAnswers">
        /// <c>true</c>, if the poll allows multiple answers, ignored for polls in quiz mode,
        /// defaults to <c>false</c>
        /// </param>
        /// <param name="correctOptionId">
        /// 0-based identifier of the correct answer option, required for polls in quiz mode
        /// </param>
        /// <param name="explanation">
        /// Text that is shown when a user chooses an incorrect answer or taps on the lamp icon in a quiz-style poll,
        /// 0-200 characters with at most 2 line feeds after entities parsing
        /// </param>
        /// <param name="explanationParseMode">
        /// Mode for parsing entities in the explanation. See
        /// <a href="https://core.telegram.org/bots/api#formatting-options">formatting options</a>
        /// for more details
        /// </param>
        /// <param name="explanationEntities">
        /// List of special entities that appear in the poll explanation, which can be specified instead
        /// of <see cref="ParseMode"/>
        /// </param>
        /// <param name="openPeriod">
        /// Amount of time in seconds the poll will be active after creation, 5-600. Can't be used together
        /// with <paramref name="closeDate"/>
        /// </param>
        /// <param name="closeDate">
        /// Point in time when the poll will be automatically closed. Must be at least 5 and no more than 600 seconds
        /// in the future. Can't be used together with <paramref name="openPeriod"/>
        /// </param>
        /// <param name="isClosed">
        /// Pass <c>true</c>, if the poll needs to be immediately closed. This can be useful for poll preview
        /// </param>
        /// <param name="disableNotification">
        /// Sends the message silently. Users will receive a notification with no sound
        /// </param>
        /// <param name="protectContent">Protects the contents of sent messages from forwarding and saving</param>
        /// <param name="replyToMessageId">If the message is a reply, ID of the original message</param>
        /// <param name="allowSendingWithoutReply">
        /// Pass <c>true</c>, if the message should be sent even if the specified replied-to message is not found
        /// </param>
        /// <param name="replyMarkup">
        /// Additional interface options. An <see cref="InlineKeyboardMarkup">inline keyboard</see>,
        /// <see cref="ReplyKeyboardMarkup">custom reply keyboard</see>, instructions to
        /// <see cref="ReplyKeyboardRemove">remove reply keyboard</see> or to
        /// <see cref="ForceReplyMarkup">force a reply</see> from the user
        /// </param>
        /// <param name="cancellationToken">
        /// A cancellation token that can be used by other objects or threads to receive notice of cancellation
        /// </param>
        /// <returns>On success, the sent <see cref="Message"/> is returned.</returns>
        public Task<Message> SendPollAsync(
            string question,
            IEnumerable<string> options,
            bool? isAnonymous = default,
            PollType? type = default,
            bool? allowsMultipleAnswers = default,
            int? correctOptionId = default,
            string? explanation = default,
            ParseMode? explanationParseMode = default,
            IEnumerable<MessageEntity>? explanationEntities = default,
            int? openPeriod = default,
            DateTime? closeDate = default,
            bool? isClosed = default,
            bool? disableNotification = default,
            bool? protectContent = default,
            int? replyToMessageId = default,
            bool? allowSendingWithoutReply = default,
            IReplyMarkup? replyMarkup = default,
            CancellationToken cancellationToken = default)
        {
            return Client.SendPollAsync(ChatId, question, options, isAnonymous, type, allowsMultipleAnswers, correctOptionId, explanation, explanationParseMode, explanationEntities, openPeriod, closeDate, isClosed, disableNotification, protectContent, replyToMessageId, allowSendingWithoutReply, replyMarkup, cancellationToken);
        }

        /// <summary>
        /// Use this method to send a native poll.
        /// </summary>
        /// <param name="botClient">An instance of <see cref="ITelegramBotClient"/></param>
        /// <param name="chatId">
        /// Unique identifier for the target chat or username of the target channel
        /// (in the format <c>@channelusername</c>)
        /// </param>
        /// <param name="question">Poll question, 1-300 characters</param>
        /// <param name="options">A list of answer options, 2-10 strings 1-100 characters each</param>
        /// <param name="isAnonymous"><c>true</c>, if the poll needs to be anonymous, defaults to <c>true</c></param>
        /// <param name="type">
        /// Poll type, <see cref="PollType.Quiz"/> or <see cref="PollType.Regular"/>,
        /// defaults to <see cref="PollType.Regular"/>
        /// </param>
        /// <param name="allowsMultipleAnswers">
        /// <c>true</c>, if the poll allows multiple answers, ignored for polls in quiz mode,
        /// defaults to <c>false</c>
        /// </param>
        /// <param name="correctOptionId">
        /// 0-based identifier of the correct answer option, required for polls in quiz mode
        /// </param>
        /// <param name="explanation">
        /// Text that is shown when a user chooses an incorrect answer or taps on the lamp icon in a quiz-style poll,
        /// 0-200 characters with at most 2 line feeds after entities parsing
        /// </param>
        /// <param name="explanationParseMode">
        /// Mode for parsing entities in the explanation. See
        /// <a href="https://core.telegram.org/bots/api#formatting-options">formatting options</a>
        /// for more details
        /// </param>
        /// <param name="explanationEntities">
        /// List of special entities that appear in the poll explanation, which can be specified instead
        /// of <see cref="ParseMode"/>
        /// </param>
        /// <param name="openPeriod">
        /// Amount of time in seconds the poll will be active after creation, 5-600. Can't be used together
        /// with <paramref name="closeDate"/>
        /// </param>
        /// <param name="closeDate">
        /// Point in time when the poll will be automatically closed. Must be at least 5 and no more than 600 seconds
        /// in the future. Can't be used together with <paramref name="openPeriod"/>
        /// </param>
        /// <param name="isClosed">
        /// Pass <c>true</c>, if the poll needs to be immediately closed. This can be useful for poll preview
        /// </param>
        /// <param name="disableNotification">
        /// Sends the message silently. Users will receive a notification with no sound
        /// </param>
        /// <param name="protectContent">Protects the contents of sent messages from forwarding and saving</param>
        /// <param name="replyToMessageId">If the message is a reply, ID of the original message</param>
        /// <param name="allowSendingWithoutReply">
        /// Pass <c>true</c>, if the message should be sent even if the specified replied-to message is not found
        /// </param>
        /// <param name="replyMarkup">
        /// Additional interface options. An <see cref="InlineKeyboardMarkup">inline keyboard</see>,
        /// <see cref="ReplyKeyboardMarkup">custom reply keyboard</see>, instructions to
        /// <see cref="ReplyKeyboardRemove">remove reply keyboard</see> or to
        /// <see cref="ForceReplyMarkup">force a reply</see> from the user
        /// </param>
        /// <param name="cancellationToken">
        /// A cancellation token that can be used by other objects or threads to receive notice of cancellation
        /// </param>
        /// <returns>On success, the sent <see cref="Message"/> is returned.</returns>
        public Task<Message> SendPollAsync(
            ChatId chatId,
            string question,
            IEnumerable<string> options,
            bool? isAnonymous = default,
            PollType? type = default,
            bool? allowsMultipleAnswers = default,
            int? correctOptionId = default,
            string? explanation = default,
            ParseMode? explanationParseMode = default,
            IEnumerable<MessageEntity>? explanationEntities = default,
            int? openPeriod = default,
            DateTime? closeDate = default,
            bool? isClosed = default,
            bool? disableNotification = default,
            bool? protectContent = default,
            int? replyToMessageId = default,
            bool? allowSendingWithoutReply = default,
            IReplyMarkup? replyMarkup = default,
            CancellationToken cancellationToken = default)
        {
            return Client.SendPollAsync(chatId, question, options, isAnonymous, type, allowsMultipleAnswers, correctOptionId, explanation, explanationParseMode, explanationEntities, openPeriod, closeDate, isClosed, disableNotification, protectContent, replyToMessageId, allowSendingWithoutReply, replyMarkup, cancellationToken);
        }

        /// <summary>
        /// Use this method to send static .WEBP or animated .TGS stickers.
        /// </summary>
        /// <param name="botClient">An instance of <see cref="ITelegramBotClient"/></param>
        /// <param name="chatId">
        /// Unique identifier for the target chat or username of the target channel
        /// (in the format <c>@channelusername</c>)
        /// </param>
        /// <param name="sticker">
        /// Sticker to send. Pass a <see cref="InputTelegramFile.FileId"/> as String to send a file that exists on
        /// the Telegram servers (recommended), pass an HTTP URL as a String for Telegram to get a .WEBP file from
        /// the Internet, or upload a new one using multipart/form-data
        /// </param>
        /// <param name="disableNotification">
        /// Sends the message silently. Users will receive a notification with no sound
        /// </param>
        /// <param name="protectContent">Protects the contents of sent messages from forwarding and saving</param>
        /// <param name="replyToMessageId">If the message is a reply, ID of the original message</param>
        /// <param name="allowSendingWithoutReply">
        /// Pass <c>true</c>, if the message should be sent even if the specified replied-to message is not found
        /// </param>
        /// <param name="replyMarkup">
        /// Additional interface options. An <see cref="InlineKeyboardMarkup">inline keyboard</see>,
        /// <see cref="ReplyKeyboardMarkup">custom reply keyboard</see>, instructions to
        /// <see cref="ReplyKeyboardRemove">remove reply keyboard</see> or to
        /// <see cref="ForceReplyMarkup">force a reply</see> from the user
        /// </param>
        /// <param name="cancellationToken">
        /// A cancellation token that can be used by other objects or threads to receive notice of cancellation
        /// </param>
        /// <returns>On success, the sent <see cref="Message"/> is returned.</returns>
        public Task<Message> SendStickerAsync(
            InputOnlineFile sticker,
            bool? disableNotification = default,
            bool? protectContent = default,
            int? replyToMessageId = default,
            bool? allowSendingWithoutReply = default,
            IReplyMarkup? replyMarkup = default,
            CancellationToken cancellationToken = default)
        {
            return Client.SendStickerAsync(ChatId, sticker, disableNotification, protectContent, replyToMessageId, allowSendingWithoutReply, replyMarkup, cancellationToken);
        }

        /// <summary>
        /// Use this method to send static .WEBP or animated .TGS stickers.
        /// </summary>
        /// <param name="botClient">An instance of <see cref="ITelegramBotClient"/></param>
        /// <param name="chatId">
        /// Unique identifier for the target chat or username of the target channel
        /// (in the format <c>@channelusername</c>)
        /// </param>
        /// <param name="sticker">
        /// Sticker to send. Pass a <see cref="InputTelegramFile.FileId"/> as String to send a file that exists on
        /// the Telegram servers (recommended), pass an HTTP URL as a String for Telegram to get a .WEBP file from
        /// the Internet, or upload a new one using multipart/form-data
        /// </param>
        /// <param name="disableNotification">
        /// Sends the message silently. Users will receive a notification with no sound
        /// </param>
        /// <param name="protectContent">Protects the contents of sent messages from forwarding and saving</param>
        /// <param name="replyToMessageId">If the message is a reply, ID of the original message</param>
        /// <param name="allowSendingWithoutReply">
        /// Pass <c>true</c>, if the message should be sent even if the specified replied-to message is not found
        /// </param>
        /// <param name="replyMarkup">
        /// Additional interface options. An <see cref="InlineKeyboardMarkup">inline keyboard</see>,
        /// <see cref="ReplyKeyboardMarkup">custom reply keyboard</see>, instructions to
        /// <see cref="ReplyKeyboardRemove">remove reply keyboard</see> or to
        /// <see cref="ForceReplyMarkup">force a reply</see> from the user
        /// </param>
        /// <param name="cancellationToken">
        /// A cancellation token that can be used by other objects or threads to receive notice of cancellation
        /// </param>
        /// <returns>On success, the sent <see cref="Message"/> is returned.</returns>
        public Task<Message> SendStickerAsync(
            ChatId chatId,
            InputOnlineFile sticker,
            bool? disableNotification = default,
            bool? protectContent = default,
            int? replyToMessageId = default,
            bool? allowSendingWithoutReply = default,
            IReplyMarkup? replyMarkup = default,
            CancellationToken cancellationToken = default)
        {
            return Client.SendStickerAsync(chatId, sticker, disableNotification, protectContent, replyToMessageId, allowSendingWithoutReply, replyMarkup, cancellationToken);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="text"></param>
        /// <param name="parseMode"></param>
        /// <param name="disableWebPagePreview"></param>
        /// <param name="disableNotification"></param>
        /// <param name="replyToMessageId"></param>
        /// <param name="replyMarkup"></param>
        /// <param name="entities"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public Task<Message> SendTextMessageV2Async(string text, ParseMode parseMode = 0, bool disableWebPagePreview = false, bool disableNotification = false, int replyToMessageId = 0, IReplyMarkup replyMarkup = null, MessageEntity[] entities = default, CancellationToken cancellationToken = default)
        {
            return Client.SendTextMessageV2Async(ChatId, text, parseMode, disableWebPagePreview, disableNotification, replyToMessageId, replyMarkup, entities, cancellationToken);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="chatId"></param>
        /// <param name="text"></param>
        /// <param name="parseMode"></param>
        /// <param name="disableWebPagePreview"></param>
        /// <param name="disableNotification"></param>
        /// <param name="replyToMessageId"></param>
        /// <param name="replyMarkup"></param>
        /// <param name="entities"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public Task<Message> SendTextMessageV2Async(ChatId chatId, string text, ParseMode parseMode = 0, bool disableWebPagePreview = false, bool disableNotification = false, int replyToMessageId = 0, IReplyMarkup replyMarkup = null, MessageEntity[] entities = default, CancellationToken cancellationToken = default)
        {
            return Client.SendTextMessageV2Async(chatId, text, parseMode, disableWebPagePreview, disableNotification, replyToMessageId, replyMarkup, entities, cancellationToken);
        }

        /// <summary>
        /// Use this method to send text messages.
        /// </summary>
        /// <param name="botClient">An instance of <see cref="ITelegramBotClient"/></param>
        /// <param name="chatId">
        /// Unique identifier for the target chat or username of the target channel
        /// (in the format <c>@channelusername</c>)
        /// </param>
        /// <param name="text">Text of the message to be sent, 1-4096 characters after entities parsing</param>
        /// <param name="parseMode">
        /// Mode for parsing entities in the new caption. See
        /// <a href="https://core.telegram.org/bots/api#formatting-options">formatting</a> options for more
        /// details
        /// </param>
        /// <param name="entities">
        /// List of special entities that appear in message text, which can be specified instead
        /// of <see cref="ParseMode"/>
        /// </param>
        /// <param name="disableWebPagePreview">Disables link previews for links in this message</param>
        /// <param name="disableNotification">
        /// Sends the message silently. Users will receive a notification with no sound
        /// </param>
        /// <param name="protectContent">Protects the contents of sent messages from forwarding and saving</param>
        /// <param name="replyToMessageId">If the message is a reply, ID of the original message</param>
        /// <param name="allowSendingWithoutReply">
        /// Pass <c>true</c>, if the message should be sent even if the specified replied-to message is not found
        /// </param>
        /// <param name="replyMarkup">
        /// Additional interface options. An <see cref="InlineKeyboardMarkup">inline keyboard</see>,
        /// <see cref="ReplyKeyboardMarkup">custom reply keyboard</see>, instructions to
        /// <see cref="ReplyKeyboardRemove">remove reply keyboard</see> or to <see cref="ForceReplyMarkup">force a
        /// reply</see> from the user
        /// </param>
        /// <param name="cancellationToken">
        /// A cancellation token that can be used by other objects or threads to receive notice of cancellation
        /// </param>
        /// <returns>On success, the sent <see cref="Message"/> is returned.</returns>
        public Task<Message> SendTextMessageAsync(
            string text,
            ParseMode? parseMode = default,
            IEnumerable<MessageEntity>? entities = default,
            bool? disableWebPagePreview = default,
            bool? disableNotification = default,
            bool? protectContent = default,
            int? replyToMessageId = default,
            bool? allowSendingWithoutReply = default,
            IReplyMarkup? replyMarkup = default,
            CancellationToken cancellationToken = default)
        {
            return Client.SendTextMessageAsync(ChatId, text, parseMode, entities, disableWebPagePreview, disableNotification, protectContent, replyToMessageId, allowSendingWithoutReply, replyMarkup, cancellationToken);
        }

        /// <summary>
        /// Use this method to send text messages.
        /// </summary>
        /// <param name="botClient">An instance of <see cref="ITelegramBotClient"/></param>
        /// <param name="chatId">
        /// Unique identifier for the target chat or username of the target channel
        /// (in the format <c>@channelusername</c>)
        /// </param>
        /// <param name="text">Text of the message to be sent, 1-4096 characters after entities parsing</param>
        /// <param name="parseMode">
        /// Mode for parsing entities in the new caption. See
        /// <a href="https://core.telegram.org/bots/api#formatting-options">formatting</a> options for more
        /// details
        /// </param>
        /// <param name="entities">
        /// List of special entities that appear in message text, which can be specified instead
        /// of <see cref="ParseMode"/>
        /// </param>
        /// <param name="disableWebPagePreview">Disables link previews for links in this message</param>
        /// <param name="disableNotification">
        /// Sends the message silently. Users will receive a notification with no sound
        /// </param>
        /// <param name="protectContent">Protects the contents of sent messages from forwarding and saving</param>
        /// <param name="replyToMessageId">If the message is a reply, ID of the original message</param>
        /// <param name="allowSendingWithoutReply">
        /// Pass <c>true</c>, if the message should be sent even if the specified replied-to message is not found
        /// </param>
        /// <param name="replyMarkup">
        /// Additional interface options. An <see cref="InlineKeyboardMarkup">inline keyboard</see>,
        /// <see cref="ReplyKeyboardMarkup">custom reply keyboard</see>, instructions to
        /// <see cref="ReplyKeyboardRemove">remove reply keyboard</see> or to <see cref="ForceReplyMarkup">force a
        /// reply</see> from the user
        /// </param>
        /// <param name="cancellationToken">
        /// A cancellation token that can be used by other objects or threads to receive notice of cancellation
        /// </param>
        /// <returns>On success, the sent <see cref="Message"/> is returned.</returns>
        public Task<Message> SendTextMessageAsync(
            ChatId chatId,
            string text,
            ParseMode? parseMode = default,
            IEnumerable<MessageEntity>? entities = default,
            bool? disableWebPagePreview = default,
            bool? disableNotification = default,
            bool? protectContent = default,
            int? replyToMessageId = default,
            bool? allowSendingWithoutReply = default,
            IReplyMarkup? replyMarkup = default,
            CancellationToken cancellationToken = default)
        {
            return Client.SendTextMessageAsync(chatId, text, parseMode, entities, disableWebPagePreview, disableNotification, protectContent, replyToMessageId, allowSendingWithoutReply, replyMarkup, cancellationToken);
        }

        /// <summary>
        /// Use this method to send information about a venue.
        /// </summary>
        /// <param name="botClient">An instance of <see cref="ITelegramBotClient"/></param>
        /// <param name="latitude">Latitude of the venue</param>
        /// <param name="longitude">Longitude of the venue</param>
        /// <param name="title">Name of the venue</param>
        /// <param name="address">Address of the venue</param>
        /// <param name="foursquareId">Foursquare identifier of the venue</param>
        /// <param name="foursquareType">
        /// Foursquare type of the venue, if known. (For example, “arts_entertainment/default”,
        /// “arts_entertainment/aquarium” or “food/icecream”.)
        /// </param>
        /// <param name="googlePlaceId">Google Places identifier of the venue</param>
        /// <param name="googlePlaceType">
        /// Google Places type of the venue. (See
        /// <a href="https://developers.google.com/places/web-service/supported_types">supported types</a>)
        /// </param>
        /// <param name="disableNotification">
        /// Sends the message silently. Users will receive a notification with no sound
        /// </param>
        /// <param name="protectContent">Protects the contents of sent messages from forwarding and saving</param>
        /// <param name="replyToMessageId">If the message is a reply, ID of the original message</param>
        /// <param name="allowSendingWithoutReply">
        /// Pass <c>true</c>, if the message should be sent even if the specified replied-to message is not found
        /// </param>
        /// <param name="replyMarkup">
        /// Additional interface options. An <see cref="InlineKeyboardMarkup">inline keyboard</see>,
        /// <see cref="ReplyKeyboardMarkup">custom reply keyboard</see>, instructions to
        /// <see cref="ReplyKeyboardRemove">remove reply keyboard</see> or to
        /// <see cref="ForceReplyMarkup">force a reply</see> from the user
        /// </param>
        /// <param name="cancellationToken">
        /// A cancellation token that can be used by other objects or threads to receive notice of cancellation
        /// </param>
        /// <returns>On success, the sent <see cref="Message"/> is returned.</returns>
        /// <a href="https://core.telegram.org/bots/api#sendvenue"/>
        public Task<Message> SendVenueAsync(
            double latitude,
            double longitude,
            string title,
            string address,
            string? foursquareId = default,
            string? foursquareType = default,
            string? googlePlaceId = default,
            string? googlePlaceType = default,
            bool? disableNotification = default,
            bool? protectContent = default,
            int? replyToMessageId = default,
            bool? allowSendingWithoutReply = default,
            IReplyMarkup? replyMarkup = default,
            CancellationToken cancellationToken = default)
        {
            return Client.SendVenueAsync(ChatId, latitude, longitude, title, address, foursquareId, foursquareType, googlePlaceId, googlePlaceType, disableNotification, protectContent, replyToMessageId, allowSendingWithoutReply, replyMarkup, cancellationToken);
        }

        /// <summary>
        /// Use this method to send information about a venue.
        /// </summary>
        /// <param name="botClient">An instance of <see cref="ITelegramBotClient"/></param>
        /// <param name="chatId">
        /// Unique identifier for the target chat or username of the target channel
        /// (in the format <c>@channelusername</c>)
        /// </param>
        /// <param name="latitude">Latitude of the venue</param>
        /// <param name="longitude">Longitude of the venue</param>
        /// <param name="title">Name of the venue</param>
        /// <param name="address">Address of the venue</param>
        /// <param name="foursquareId">Foursquare identifier of the venue</param>
        /// <param name="foursquareType">
        /// Foursquare type of the venue, if known. (For example, “arts_entertainment/default”,
        /// “arts_entertainment/aquarium” or “food/icecream”.)
        /// </param>
        /// <param name="googlePlaceId">Google Places identifier of the venue</param>
        /// <param name="googlePlaceType">
        /// Google Places type of the venue. (See
        /// <a href="https://developers.google.com/places/web-service/supported_types">supported types</a>)
        /// </param>
        /// <param name="disableNotification">
        /// Sends the message silently. Users will receive a notification with no sound
        /// </param>
        /// <param name="protectContent">Protects the contents of sent messages from forwarding and saving</param>
        /// <param name="replyToMessageId">If the message is a reply, ID of the original message</param>
        /// <param name="allowSendingWithoutReply">
        /// Pass <c>true</c>, if the message should be sent even if the specified replied-to message is not found
        /// </param>
        /// <param name="replyMarkup">
        /// Additional interface options. An <see cref="InlineKeyboardMarkup">inline keyboard</see>,
        /// <see cref="ReplyKeyboardMarkup">custom reply keyboard</see>, instructions to
        /// <see cref="ReplyKeyboardRemove">remove reply keyboard</see> or to
        /// <see cref="ForceReplyMarkup">force a reply</see> from the user
        /// </param>
        /// <param name="cancellationToken">
        /// A cancellation token that can be used by other objects or threads to receive notice of cancellation
        /// </param>
        /// <returns>On success, the sent <see cref="Message"/> is returned.</returns>
        /// <a href="https://core.telegram.org/bots/api#sendvenue"/>
        public Task<Message> SendVenueAsync(
            ChatId chatId,
            double latitude,
            double longitude,
            string title,
            string address,
            string? foursquareId = default,
            string? foursquareType = default,
            string? googlePlaceId = default,
            string? googlePlaceType = default,
            bool? disableNotification = default,
            bool? protectContent = default,
            int? replyToMessageId = default,
            bool? allowSendingWithoutReply = default,
            IReplyMarkup? replyMarkup = default,
            CancellationToken cancellationToken = default)
        {
            return Client.SendVenueAsync(chatId, latitude, longitude, title, address, foursquareId, foursquareType, googlePlaceId, googlePlaceType, disableNotification, protectContent, replyToMessageId, allowSendingWithoutReply, replyMarkup, cancellationToken);
        }

        /// <summary>
        /// Use this method to send video files, Telegram clients support mp4 videos (other formats may be sent as
        /// <see cref="Document"/>). Bots can currently send video files of up to 50 MB in size, this limit may be
        /// changed in the future.
        /// </summary>
        /// <param name="botClient">An instance of <see cref="ITelegramBotClient"/></param>
        /// <param name="video">
        /// Video to send. Pass a <see cref="InputTelegramFile.FileId"/> as String to send a video that exists on
        /// the Telegram servers (recommended), pass an HTTP URL as a String for Telegram to get a video from the
        /// Internet, or upload a new video using multipart/form-data
        /// </param>
        /// <param name="duration">Duration of sent video in seconds</param>
        /// <param name="width">Video width</param>
        /// <param name="height">Video height</param>
        /// <param name="thumb">
        /// Thumbnail of the file sent; can be ignored if thumbnail generation for the file is supported server-side.
        /// The thumbnail should be in JPEG format and less than 200 kB in size. A thumbnail's width and height should
        /// not exceed 320. Ignored if the file is not uploaded using multipart/form-data. Thumbnails can't be reused
        /// and can be only uploaded as a new file, so you can pass "attach://&lt;file_attach_name&gt;" if the
        /// thumbnail was uploaded using multipart/form-data under &lt;file_attach_name&gt;
        /// </param>
        /// <param name="caption">
        /// Video caption (may also be used when resending videos by file_id), 0-1024 characters after entities parsing
        /// </param>
        /// <param name="parseMode">
        /// Mode for parsing entities in the new caption. See
        /// <a href="https://core.telegram.org/bots/api#formatting-options">formatting</a> options for
        /// more details
        /// </param>
        /// <param name="captionEntities">
        /// List of special entities that appear in the caption, which can be specified instead
        /// of <see cref="ParseMode"/>
        /// </param>
        /// <param name="supportsStreaming">Pass <c>true</c>, if the uploaded video is suitable for streaming</param>
        /// <param name="disableNotification">
        /// Sends the message silently. Users will receive a notification with no sound
        /// </param>
        /// <param name="protectContent">Protects the contents of sent messages from forwarding and saving</param>
        /// <param name="replyToMessageId">If the message is a reply, ID of the original message</param>
        /// <param name="allowSendingWithoutReply">
        /// Pass <c>true</c>, if the message should be sent even if the specified replied-to message is not found
        /// </param>
        /// <param name="replyMarkup">
        /// Additional interface options. An <see cref="InlineKeyboardMarkup">inline keyboard</see>,
        /// <see cref="ReplyKeyboardMarkup">custom reply keyboard</see>, instructions to
        /// <see cref="ReplyKeyboardRemove">remove reply keyboard</see> or to
        /// <see cref="ForceReplyMarkup">force a reply</see> from the user
        /// </param>
        /// <param name="cancellationToken">
        /// A cancellation token that can be used by other objects or threads to receive notice of cancellation
        /// </param>
        /// <returns>On success, the sent <see cref="Message"/> is returned.</returns>
        public Task<Message> SendVideoAsync(
            InputOnlineFile video,
            int? duration = default,
            int? width = default,
            int? height = default,
            InputMedia? thumb = default,
            string? caption = default,
            ParseMode? parseMode = default,
            IEnumerable<MessageEntity>? captionEntities = default,
            bool? supportsStreaming = default,
            bool? disableNotification = default,
            bool? protectContent = default,
            int? replyToMessageId = default,
            bool? allowSendingWithoutReply = default,
            IReplyMarkup? replyMarkup = default,
            CancellationToken cancellationToken = default)
        {
            return Client.SendVideoAsync(ChatId, video, duration, width, height, thumb, caption, parseMode, captionEntities, supportsStreaming, disableNotification, protectContent, replyToMessageId, allowSendingWithoutReply, replyMarkup, cancellationToken);
        }

        /// <summary>
        /// Use this method to send video files, Telegram clients support mp4 videos (other formats may be sent as
        /// <see cref="Document"/>). Bots can currently send video files of up to 50 MB in size, this limit may be
        /// changed in the future.
        /// </summary>
        /// <param name="botClient">An instance of <see cref="ITelegramBotClient"/></param>
        /// <param name="chatId">
        /// Unique identifier for the target chat or username of the target channel
        /// (in the format <c>@channelusername</c>)
        /// </param>
        /// <param name="video">
        /// Video to send. Pass a <see cref="InputTelegramFile.FileId"/> as String to send a video that exists on
        /// the Telegram servers (recommended), pass an HTTP URL as a String for Telegram to get a video from the
        /// Internet, or upload a new video using multipart/form-data
        /// </param>
        /// <param name="duration">Duration of sent video in seconds</param>
        /// <param name="width">Video width</param>
        /// <param name="height">Video height</param>
        /// <param name="thumb">
        /// Thumbnail of the file sent; can be ignored if thumbnail generation for the file is supported server-side.
        /// The thumbnail should be in JPEG format and less than 200 kB in size. A thumbnail's width and height should
        /// not exceed 320. Ignored if the file is not uploaded using multipart/form-data. Thumbnails can't be reused
        /// and can be only uploaded as a new file, so you can pass "attach://&lt;file_attach_name&gt;" if the
        /// thumbnail was uploaded using multipart/form-data under &lt;file_attach_name&gt;
        /// </param>
        /// <param name="caption">
        /// Video caption (may also be used when resending videos by file_id), 0-1024 characters after entities parsing
        /// </param>
        /// <param name="parseMode">
        /// Mode for parsing entities in the new caption. See
        /// <a href="https://core.telegram.org/bots/api#formatting-options">formatting</a> options for
        /// more details
        /// </param>
        /// <param name="captionEntities">
        /// List of special entities that appear in the caption, which can be specified instead
        /// of <see cref="ParseMode"/>
        /// </param>
        /// <param name="supportsStreaming">Pass <c>true</c>, if the uploaded video is suitable for streaming</param>
        /// <param name="disableNotification">
        /// Sends the message silently. Users will receive a notification with no sound
        /// </param>
        /// <param name="protectContent">Protects the contents of sent messages from forwarding and saving</param>
        /// <param name="replyToMessageId">If the message is a reply, ID of the original message</param>
        /// <param name="allowSendingWithoutReply">
        /// Pass <c>true</c>, if the message should be sent even if the specified replied-to message is not found
        /// </param>
        /// <param name="replyMarkup">
        /// Additional interface options. An <see cref="InlineKeyboardMarkup">inline keyboard</see>,
        /// <see cref="ReplyKeyboardMarkup">custom reply keyboard</see>, instructions to
        /// <see cref="ReplyKeyboardRemove">remove reply keyboard</see> or to
        /// <see cref="ForceReplyMarkup">force a reply</see> from the user
        /// </param>
        /// <param name="cancellationToken">
        /// A cancellation token that can be used by other objects or threads to receive notice of cancellation
        /// </param>
        /// <returns>On success, the sent <see cref="Message"/> is returned.</returns>
        public Task<Message> SendVideoAsync(
            ChatId chatId,
            InputOnlineFile video,
            int? duration = default,
            int? width = default,
            int? height = default,
            InputMedia? thumb = default,
            string? caption = default,
            ParseMode? parseMode = default,
            IEnumerable<MessageEntity>? captionEntities = default,
            bool? supportsStreaming = default,
            bool? disableNotification = default,
            bool? protectContent = default,
            int? replyToMessageId = default,
            bool? allowSendingWithoutReply = default,
            IReplyMarkup? replyMarkup = default,
            CancellationToken cancellationToken = default)
        {
            return Client.SendVideoAsync(chatId, video, duration, width, height, thumb, caption, parseMode, captionEntities, supportsStreaming, disableNotification, protectContent, replyToMessageId, allowSendingWithoutReply, replyMarkup, cancellationToken);
        }

        /// <summary>
        /// As of <a href="https://telegram.org/blog/video-messages-and-telescope">v.4.0</a>, Telegram clients
        /// support rounded square mp4 videos of up to 1 minute long. Use this method to send video messages.
        /// </summary>
        /// <param name="botClient">An instance of <see cref="ITelegramBotClient"/></param>
        /// <param name="videoNote">
        /// Video note to send. Pass a <see cref="InputTelegramFile.FileId"/> as String to send a video note that
        /// exists on the Telegram servers (recommended) or upload a new video using multipart/form-data. Sending
        /// video notes by a URL is currently unsupported
        /// </param>
        /// <param name="duration">Duration of sent video in seconds</param>
        /// <param name="length">Video width and height, i.e. diameter of the video message</param>
        /// <param name="thumb">
        /// Thumbnail of the file sent; can be ignored if thumbnail generation for the file is supported server-side.
        /// The thumbnail should be in JPEG format and less than 200 kB in size. A thumbnail's width and height should
        /// not exceed 320. Ignored if the file is not uploaded using multipart/form-data. Thumbnails can't be reused
        /// and can be only uploaded as a new file, so you can pass "attach://&lt;file_attach_name&gt;" if the
        /// thumbnail was uploaded using multipart/form-data under &lt;file_attach_name&gt;
        /// </param>
        /// <param name="disableNotification">
        /// Sends the message silently. Users will receive a notification with no sound
        /// </param>
        /// <param name="protectContent">Protects the contents of sent messages from forwarding and saving</param>
        /// <param name="replyToMessageId">If the message is a reply, ID of the original message</param>
        /// <param name="allowSendingWithoutReply">
        /// Pass <c>true</c>, if the message should be sent even if the specified replied-to message is not found
        /// </param>
        /// <param name="replyMarkup">
        /// Additional interface options. An <see cref="InlineKeyboardMarkup">inline keyboard</see>,
        /// <see cref="ReplyKeyboardMarkup">custom reply keyboard</see>, instructions to
        /// <see cref="ReplyKeyboardRemove">remove reply keyboard</see> or to
        /// <see cref="ForceReplyMarkup">force a reply</see> from the user
        /// </param>
        /// <param name="cancellationToken">
        /// A cancellation token that can be used by other objects or threads to receive notice of cancellation
        /// </param>
        /// <returns>On success, the sent <see cref="Message"/> is returned.</returns>
        public Task<Message> SendVideoNoteAsync(
            InputTelegramFile videoNote,
            int? duration = default,
            int? length = default,
            InputMedia? thumb = default,
            bool? disableNotification = default,
            bool? protectContent = default,
            int? replyToMessageId = default,
            bool? allowSendingWithoutReply = default,
            IReplyMarkup? replyMarkup = default,
            CancellationToken cancellationToken = default)
        {
            return Client.SendVideoNoteAsync(ChatId, videoNote, duration, length, thumb, disableNotification, protectContent, replyToMessageId, allowSendingWithoutReply, replyMarkup, cancellationToken);
        }

        /// <summary>
        /// As of <a href="https://telegram.org/blog/video-messages-and-telescope">v.4.0</a>, Telegram clients
        /// support rounded square mp4 videos of up to 1 minute long. Use this method to send video messages.
        /// </summary>
        /// <param name="botClient">An instance of <see cref="ITelegramBotClient"/></param>
        /// <param name="chatId">
        /// Unique identifier for the target chat or username of the target channel
        /// (in the format <c>@channelusername</c>)
        /// </param>
        /// <param name="videoNote">
        /// Video note to send. Pass a <see cref="InputTelegramFile.FileId"/> as String to send a video note that
        /// exists on the Telegram servers (recommended) or upload a new video using multipart/form-data. Sending
        /// video notes by a URL is currently unsupported
        /// </param>
        /// <param name="duration">Duration of sent video in seconds</param>
        /// <param name="length">Video width and height, i.e. diameter of the video message</param>
        /// <param name="thumb">
        /// Thumbnail of the file sent; can be ignored if thumbnail generation for the file is supported server-side.
        /// The thumbnail should be in JPEG format and less than 200 kB in size. A thumbnail's width and height should
        /// not exceed 320. Ignored if the file is not uploaded using multipart/form-data. Thumbnails can't be reused
        /// and can be only uploaded as a new file, so you can pass "attach://&lt;file_attach_name&gt;" if the
        /// thumbnail was uploaded using multipart/form-data under &lt;file_attach_name&gt;
        /// </param>
        /// <param name="disableNotification">
        /// Sends the message silently. Users will receive a notification with no sound
        /// </param>
        /// <param name="protectContent">Protects the contents of sent messages from forwarding and saving</param>
        /// <param name="replyToMessageId">If the message is a reply, ID of the original message</param>
        /// <param name="allowSendingWithoutReply">
        /// Pass <c>true</c>, if the message should be sent even if the specified replied-to message is not found
        /// </param>
        /// <param name="replyMarkup">
        /// Additional interface options. An <see cref="InlineKeyboardMarkup">inline keyboard</see>,
        /// <see cref="ReplyKeyboardMarkup">custom reply keyboard</see>, instructions to
        /// <see cref="ReplyKeyboardRemove">remove reply keyboard</see> or to
        /// <see cref="ForceReplyMarkup">force a reply</see> from the user
        /// </param>
        /// <param name="cancellationToken">
        /// A cancellation token that can be used by other objects or threads to receive notice of cancellation
        /// </param>
        /// <returns>On success, the sent <see cref="Message"/> is returned.</returns>
        public Task<Message> SendVideoNoteAsync(
            ChatId chatId,
            InputTelegramFile videoNote,
            int? duration = default,
            int? length = default,
            InputMedia? thumb = default,
            bool? disableNotification = default,
            bool? protectContent = default,
            int? replyToMessageId = default,
            bool? allowSendingWithoutReply = default,
            IReplyMarkup? replyMarkup = default,
            CancellationToken cancellationToken = default)
        {
            return Client.SendVideoNoteAsync(chatId, videoNote, duration, length, thumb, disableNotification, protectContent, replyToMessageId, allowSendingWithoutReply, replyMarkup, cancellationToken);
        }

        /// <summary>
        /// Use this method to send audio files, if you want Telegram clients to display the file as a playable voice
        /// message. For this to work, your audio must be in an .OGG file encoded with OPUS (other formats may be sent
        /// as <see cref="Audio"/> or <see cref="Document"/>). Bots can currently send voice messages of up to 50 MB
        /// in size, this limit may be changed in the future.
        /// </summary>
        /// <param name="botClient">An instance of <see cref="ITelegramBotClient"/></param>
        /// <param name="voice">
        /// Audio file to send. Pass a <see cref="InputTelegramFile.FileId"/> as String to send a file that exists
        /// on the Telegram servers (recommended), pass an HTTP URL as a String for Telegram to get a file from
        /// the Internet, or upload a new one using multipart/form-data
        /// </param>
        /// <param name="caption">Voice message caption, 0-1024 characters after entities parsing</param>
        /// <param name="parseMode">
        /// Mode for parsing entities in the new caption. See
        /// <a href="https://core.telegram.org/bots/api#formatting-options">formatting</a> options for
        /// more details
        /// </param>
        /// <param name="captionEntities">
        /// List of special entities that appear in the caption, which can be specified instead
        /// of <see cref="ParseMode"/>
        /// </param>
        /// <param name="duration">Duration of the voice message in seconds</param>
        /// <param name="disableNotification">
        /// Sends the message silently. Users will receive a notification with no sound
        /// </param>
        /// <param name="protectContent">Protects the contents of sent messages from forwarding and saving</param>
        /// <param name="replyToMessageId">If the message is a reply, ID of the original message</param>
        /// <param name="allowSendingWithoutReply">
        /// Pass <c>true</c>, if the message should be sent even if the specified replied-to message is not found
        /// </param>
        /// <param name="replyMarkup">
        /// Additional interface options. An <see cref="InlineKeyboardMarkup">inline keyboard</see>,
        /// <see cref="ReplyKeyboardMarkup">custom reply keyboard</see>, instructions to
        /// <see cref="ReplyKeyboardRemove">remove reply keyboard</see> or to
        /// <see cref="ForceReplyMarkup">force a reply</see> from the user
        /// </param>
        /// <param name="cancellationToken">
        /// A cancellation token that can be used by other objects or threads to receive notice of cancellation
        /// </param>
        /// <returns>On success, the sent <see cref="Message"/> is returned.</returns>
        public Task<Message> SendVoiceAsync(
            InputOnlineFile voice,
            string? caption = default,
            ParseMode? parseMode = default,
            IEnumerable<MessageEntity>? captionEntities = default,
            int? duration = default,
            bool? disableNotification = default,
            bool? protectContent = default,
            int? replyToMessageId = default,
            bool? allowSendingWithoutReply = default,
            IReplyMarkup? replyMarkup = default,
            CancellationToken cancellationToken = default)
        {
            return Client.SendVoiceAsync(ChatId, voice, caption, parseMode, captionEntities, duration, disableNotification, protectContent, replyToMessageId, allowSendingWithoutReply, replyMarkup, cancellationToken);
        }

        /// <summary>
        /// Use this method to send audio files, if you want Telegram clients to display the file as a playable voice
        /// message. For this to work, your audio must be in an .OGG file encoded with OPUS (other formats may be sent
        /// as <see cref="Audio"/> or <see cref="Document"/>). Bots can currently send voice messages of up to 50 MB
        /// in size, this limit may be changed in the future.
        /// </summary>
        /// <param name="botClient">An instance of <see cref="ITelegramBotClient"/></param>
        /// <param name="chatId">
        /// Unique identifier for the target chat or username of the target channel
        /// (in the format <c>@channelusername</c>)
        /// </param>
        /// <param name="voice">
        /// Audio file to send. Pass a <see cref="InputTelegramFile.FileId"/> as String to send a file that exists
        /// on the Telegram servers (recommended), pass an HTTP URL as a String for Telegram to get a file from
        /// the Internet, or upload a new one using multipart/form-data
        /// </param>
        /// <param name="caption">Voice message caption, 0-1024 characters after entities parsing</param>
        /// <param name="parseMode">
        /// Mode for parsing entities in the new caption. See
        /// <a href="https://core.telegram.org/bots/api#formatting-options">formatting</a> options for
        /// more details
        /// </param>
        /// <param name="captionEntities">
        /// List of special entities that appear in the caption, which can be specified instead
        /// of <see cref="ParseMode"/>
        /// </param>
        /// <param name="duration">Duration of the voice message in seconds</param>
        /// <param name="disableNotification">
        /// Sends the message silently. Users will receive a notification with no sound
        /// </param>
        /// <param name="protectContent">Protects the contents of sent messages from forwarding and saving</param>
        /// <param name="replyToMessageId">If the message is a reply, ID of the original message</param>
        /// <param name="allowSendingWithoutReply">
        /// Pass <c>true</c>, if the message should be sent even if the specified replied-to message is not found
        /// </param>
        /// <param name="replyMarkup">
        /// Additional interface options. An <see cref="InlineKeyboardMarkup">inline keyboard</see>,
        /// <see cref="ReplyKeyboardMarkup">custom reply keyboard</see>, instructions to
        /// <see cref="ReplyKeyboardRemove">remove reply keyboard</see> or to
        /// <see cref="ForceReplyMarkup">force a reply</see> from the user
        /// </param>
        /// <param name="cancellationToken">
        /// A cancellation token that can be used by other objects or threads to receive notice of cancellation
        /// </param>
        /// <returns>On success, the sent <see cref="Message"/> is returned.</returns>
        public Task<Message> SendVoiceAsync(
            ChatId chatId,
            InputOnlineFile voice,
            string? caption = default,
            ParseMode? parseMode = default,
            IEnumerable<MessageEntity>? captionEntities = default,
            int? duration = default,
            bool? disableNotification = default,
            bool? protectContent = default,
            int? replyToMessageId = default,
            bool? allowSendingWithoutReply = default,
            IReplyMarkup? replyMarkup = default,
            CancellationToken cancellationToken = default)
        {
            return Client.SendVoiceAsync(chatId, voice, caption, parseMode, captionEntities, duration, disableNotification, protectContent, replyToMessageId, allowSendingWithoutReply, replyMarkup, cancellationToken);
        }
    }
}
