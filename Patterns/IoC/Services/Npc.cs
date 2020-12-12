using IoC.Abstractions;

namespace IoC.Services
{
    public class Npc
    {
        private INpc BaseNpc { get; }
        
        public Npc(INpc baseNpc)
        {
            BaseNpc = baseNpc;
        }

        public void Communicate()
        {
            BaseNpc.Talk();
        }

        public void Threaten()
        {
            BaseNpc.Threaten();
        }
    }
}