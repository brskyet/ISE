using System;
using Strategy.Abstractions;
using Strategy.Services;

namespace Patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            // Strategy
            var message = "Hell to world!";
            
            var xmlGenerator = new XmlGenerator();
            Console.WriteLine("------------XML-------------");
            Console.WriteLine(SendMessage(message, xmlGenerator));
            
            var jsonGenerator = new JsonGenerator();
            Console.WriteLine("\n\n------------JSON------------");
            Console.WriteLine(SendMessage(message, jsonGenerator));
        }

        private static string SendMessage(string message, IMessageGenerator generator)
        {
            return generator.GenerateSendingText(message);
        }
    }
}