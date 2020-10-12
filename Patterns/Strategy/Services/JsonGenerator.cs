using Strategy.Abstractions;

namespace Strategy.Services
{
    public class JsonGenerator : IMessageGenerator
    {
        public string GenerateSendingText(string message)
        {
            return $"{{ \n\t\"message\": {message}\n}}";
        }
    }
}