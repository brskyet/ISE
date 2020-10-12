namespace Strategy.Abstractions
{
    public interface IMessageGenerator
    {
        string GenerateSendingText(string message);
    }
}