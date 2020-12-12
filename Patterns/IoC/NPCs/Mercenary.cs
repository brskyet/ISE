using System;
using IoC.Abstractions;

namespace IoC.NPCs
{
    public class Mercenary : INpc
    {
        private float HitPoints { get; }
        
        private float Speed { get; }

        public Mercenary()
        {
            HitPoints = 200;
            Speed = 100;
        }
        
        public void Talk()
        {
            Console.WriteLine("I won't talk to you until you pay me!");
        }

        public void Threaten()
        {
            Console.WriteLine("I'm strong enough to crush you.");
        }
    }
}