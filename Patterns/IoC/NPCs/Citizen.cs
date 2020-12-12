using System;
using IoC.Abstractions;

namespace IoC.NPCs
{
    public class Citizen : INpc
    {
        private float HitPoints { get; }
        
        private float Speed { get; }

        public Citizen()
        {
            HitPoints = 100;
            Speed = 50;
        }
        
        public void Talk()
        {
            Console.WriteLine("Good morning! I hope you find some time to visit my store.");
        }

        public void Threaten()
        {
            Console.WriteLine($"I have only {HitPoints} HP, don't kill me!");
        }
    }
}