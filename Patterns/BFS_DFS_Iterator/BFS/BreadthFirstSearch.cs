using System.Collections.Generic;
using System.Linq;
using BFS_DFS_Iterator.Services;

namespace BFS_DFS_Iterator.BFS
{
    public class BreadthFirstSearch
    {
        private Shop _goal;
        private readonly List<Shop> _path = new List<Shop>();
        private readonly Queue<Shop> _queue = new Queue<Shop>();

        public List<Shop> Search(Shop start, Shop goal)
        {
            _queue.Enqueue(start);
            _goal = goal;
            
            while (_queue.Count != 0)
            {
                if (Search(_queue.Dequeue()))
                {
                    return _path;
                }
            }
            
            return new List<Shop>();
        }

        private bool Search(Shop shop)
        {
            _path.Add(shop);
            
            if (shop == _goal)
            {
                return true;
            }

            foreach (var c in shop.LinkedShops.Where(c => !_path.Contains(c)))
            {
                _queue.Enqueue(c);
            }

            return false;
        }
    }
}