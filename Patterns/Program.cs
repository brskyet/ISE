using System;
using System.Collections;
using ObserverAndIterator.Bank;
using Patterns.ObserverAndIterator.DetectingSystem;
using Patterns.ObserverAndIterator.Services;
using Strategy.Abstractions;
using Strategy.Services;

namespace Patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            // Strategy
            Console.WriteLine("------------Strategy------------");
            
            var message = "Hell to world!";
            
            var xmlGenerator = new XmlGenerator();
            
            Console.WriteLine("------------XML-------------");
            Console.WriteLine(SendMessage(message, xmlGenerator));
            
            var jsonGenerator = new JsonGenerator();
            
            Console.WriteLine("\n\n------------JSON------------");
            Console.WriteLine(SendMessage(message, jsonGenerator));
            
            // Observer and Iterator
            Console.WriteLine("\n\n------------Observer and Iterator------------");
            
            IEnumerable bank = new BankCollection();
            var bankManager = new BankManager();
            
            bankManager.IntruderDetected += Detector.Warning;
            
            bankManager.PrintAllCustomersBallance(bank);
        }

        private static string SendMessage(string message, IMessageGenerator generator)
        {
            return generator.GenerateSendingText(message);
        }
    }
}