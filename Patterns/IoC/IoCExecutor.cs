using System;
using IoC.NPCs;
using IoC.Services;

namespace IoC
{
    public static class IoCExecutor
    {
        public static void Execute()
        {
            var mercenary = new Mercenary();
            var citizen = new Citizen();
            
            var firstNpc = new Npc(mercenary);
            var secondNpc = new Npc(citizen);

            Console.WriteLine("First NPC");
            firstNpc.Communicate();
            firstNpc.Threaten();
            Console.WriteLine("Second NPC");
            secondNpc.Communicate();
            secondNpc.Threaten();
        }
    }
}