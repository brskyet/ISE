using System;
using System.Collections;
using IoC;
using IoC.NPCs;
using IoC.Services;
using ObserverAndIterator;
using ObserverAndIterator.Bank;
using ObserverAndIterator.DetectingSystem;
using ObserverAndIterator.Services;
using Strategy;
using Strategy.Abstractions;
using Strategy.Services;

namespace Patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            var pattern = System.Environment.GetEnvironmentVariable("Pattern");

            switch (pattern)
            {
                case { } p when p == "Strategy":
                    StrategyExecutor.Execute();
                    break;
                case { } p when p == "ObserverAndIterator":
                    ObserverAndIteratorExecutor.Execute();
                    break;
                case { } p when p == "IoC":
                    IoCExecutor.Execute();
                    break;
            }
        }
    }
}