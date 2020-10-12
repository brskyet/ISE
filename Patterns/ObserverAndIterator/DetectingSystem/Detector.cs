using System;

namespace Patterns.ObserverAndIterator.DetectingSystem
{
    public class Detector
    {
        public static void Warning(object? sender, string name)
        {
            Console.WriteLine($"Warning! Someone broke into the system and looked at the {name} data");
        }
    }
}