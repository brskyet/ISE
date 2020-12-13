using System.Collections.Generic;

namespace BFS_DFS_Iterator.Services
{
    public class Shop
    {
        public string Name { get; }
        
        public List<Shop> LinkedShops { get; }

        public Shop(string name)
        {
            Name = name;
            LinkedShops = new List<Shop>();
        }
        
        public Shop AddRoute(Shop shop, bool bidirect = true)
        {
            LinkedShops.Add(shop);
            if (bidirect)
            {
                shop.LinkedShops.Add(this);
            }
            return this;
        }
    }
}