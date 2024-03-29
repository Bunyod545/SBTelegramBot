using System.Threading;
using System.Threading.Tasks;
using Telegram.Bot.Requests;
using Telegram.Bot.Types;

namespace SB.TelegramBot
{
    /// <summary>
    /// 
    /// </summary>
    public abstract partial class TelegramBotBaseCommand
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="chatId"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public Task DeleteChatPhotoAsync(ChatId chatId, CancellationToken cancellationToken = default)
        {
            var request = new DeleteChatPhotoRequest(chatId);
            return Client.MakeRequestAsync(request, cancellationToken);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="chatId"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public Task DeleteChatStickerSetAsync(ChatId chatId, CancellationToken cancellationToken = default)
        {
            var request = new DeleteChatStickerSetRequest(chatId);
            return Client.MakeRequestAsync(request, cancellationToken);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="chatId"></param>
        /// <param name="messageId"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public Task DeleteMessageAsync(CancellationToken cancellationToken = default)
        {
            var request = new DeleteMessageRequest(ChatId, MessageId);
            return Client.MakeRequestAsync(request, cancellationToken);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="chatId"></param>
        /// <param name="messageId"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public Task DeleteMessageAsync(ChatId chatId, int messageId, CancellationToken cancellationToken = default)
        {
            var request = new DeleteMessageRequest(chatId, messageId);
            return Client.MakeRequestAsync(request, cancellationToken);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sticker"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public Task DeleteStickerFromSetAsync(InputFileId sticker, CancellationToken cancellationToken = default)
        {
            var request = new DeleteStickerFromSetRequest(sticker);
            return Client.MakeRequestAsync(request, cancellationToken);
        }
    }
}
