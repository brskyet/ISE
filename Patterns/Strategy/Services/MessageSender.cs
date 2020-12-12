using Strategy.Abstractions;

namespace Strategy.Services
{
    public class MessageSender
    {
        public static string SendMessage(string message, IMessageGenerator generator)
        {
            return generator.GenerateSendingText(message);
        }
    }
}