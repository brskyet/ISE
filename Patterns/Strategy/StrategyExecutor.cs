using System;
using Strategy.Abstractions;
using Strategy.Services;

namespace Strategy
{
    public static class StrategyExecutor
    {
        public static void Execute()
        {
            const string message = "Hell to world!";
            
            IMessageGenerator xmlGenerator = new XmlGenerator();
            
            Console.WriteLine("------------XML-------------");
            Console.WriteLine(MessageSender.SendMessage(message, xmlGenerator));
            
            IMessageGenerator jsonGenerator = new JsonGenerator();
            
            Console.WriteLine("\n\n------------JSON------------");
            Console.WriteLine(MessageSender.SendMessage(message, jsonGenerator));
        }
    }
}