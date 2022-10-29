using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Telegram.Bot.Types;
using Telegram.Bot;

namespace TelegramBot.Models
{
    public class HelloCommand : Command

    {
        public override string Name => "hello";

        public override async void Execute(Message messege, TelegramBotClient client)
        {
            var chatId = messege.Chat.Id;
            var messageId = messege.MessageId;

            await client.SendTextMessageAsync(chatId,"Hello", replyToMessageId: messageId);
        }
    }
}