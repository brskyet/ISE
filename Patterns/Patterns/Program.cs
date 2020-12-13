using System;
using AbstractFactoryAndBuilder;
using BFS_DFS_Iterator;
using IoC;
using ObserverAndIterator;
using Strategy;

namespace Patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            var pattern = Environment.GetEnvironmentVariable("Pattern");

            switch (pattern)
            {
                case { } p when p == "1:Strategy":
                    StrategyExecutor.Execute();
                    break;
                case { } p when p == "2:ObserverAndIterator":
                    ObserverAndIteratorExecutor.Execute();
                    break;
                case { } p when p == "3:IoC":
                    IoCExecutor.Execute();
                    break;
                case { } p when p == "4:AbstractFactoryAndBuilder":
                    AbstractFactoryAndBuilderExecutor.Execute();
                    break;
                case { } p when p == "5:BFS_DFS_Iterator":
                    BfsDfsIteratorExecutor.Execute();
                    break;
            }
        }
    }
}