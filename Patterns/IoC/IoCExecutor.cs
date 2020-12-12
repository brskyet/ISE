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
            
            firstNpc.Communicate();
            secondNpc.Communicate();
            firstNpc.Threaten();
            secondNpc.Threaten();
        }
    }
}