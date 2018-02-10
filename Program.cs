using System;
using Telegram.Bot;
using Telegram.Bot.Args;
using Telegram.Bot.Types.Enums;

namespace YesNoBot
{
    class Program
    {
        private static readonly TelegramBotClient Bot = new TelegramBotClient("YOUR API CODE HERE");
        private static Random rand = new Random();
        
        static void Main(string[] args)
        {
            Bot.OnMessage += BotOnMessageReceived;
            Bot.StartReceiving();
            Console.ReadKey();
            Bot.StopReceiving();
        }

        private static void BotOnMessageReceived(object sender, MessageEventArgs messageEventArgs)
        {
            var message = messageEventArgs.Message;
            if (message == null || message.Type != MessageType.TextMessage) return;

            if (message.Text.StartsWith("/yesno"))
            {
                String answer = ((rand.Next(0, 2) == 0) ? "No" : "Yes");
                Bot.SendTextMessageAsync(message.Chat.Id, answer, ParseMode.Html, false, false, message.MessageId);
                Console.WriteLine("[Q] " + message.Text);
                Console.WriteLine("[A] " + answer);
            }
        }
    }
}
