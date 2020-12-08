﻿using System;
using System.Collections;
using ObserverAndIterator.Bank;
using ObserverAndIterator.DetectingSystem;
using ObserverAndIterator.Services;
using Patterns.Helpers;
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
            
            IMessageGenerator xmlGenerator = new XmlGenerator();
            
            Console.WriteLine("------------XML-------------");
            Console.WriteLine(MessageSender.SendMessage(message, xmlGenerator));
            
            IMessageGenerator jsonGenerator = new JsonGenerator();
            
            Console.WriteLine("\n\n------------JSON------------");
            Console.WriteLine(MessageSender.SendMessage(message, jsonGenerator));
            
            // Observer and Iterator
            Console.WriteLine("\n\n------------Observer and Iterator------------");
            
            IEnumerable bank = new BankCollection();
            var bankManager = new BankManager();
            
            bankManager.IntruderDetected += Detector.Warning;
            
            bankManager.PrintAllCustomersBallance(bank);
        }
    }
}