using Strategy.Abstractions;

namespace Strategy.Services
{
    public class XmlGenerator : IMessageGenerator
    {
        public string GenerateSendingText(string message)
        {
            return $"<?xml version=\"1.0\" encoding=\"UTF-8\"?>\n<message>\n\t{message}\n</message>";
        }
    }
}