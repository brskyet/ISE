using Strategy.Abstractions;

namespace Patterns.Helpers
{
    public class MessageSender
    {
        public static string SendMessage(string message, IMessageGenerator generator)
        {
            return generator.GenerateSendingText(message);
        }
    }
}