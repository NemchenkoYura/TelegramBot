using Telegram.Bot.Types;
using Telegram.Bot;

namespace TelegramBot.Models
{
    public abstract class Command
    {
        public abstract string Name { get; }

        public abstract void Execute(Message messege, TelegramBotClient client);
        public bool Contains (string command)
        {
            return command.Contains(this.Name) && command.Contains(AppSettings.Name);
        }
    }
}