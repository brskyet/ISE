using System.Collections.Generic;
using System.Linq;
using BFS_DFS_Iterator.Services;

namespace BFS_DFS_Iterator.DFS
{
    public class DepthFirstSearch
    {
        private HashSet<Shop> _visited;
        private List<Shop> _path;
        private Shop _goal;

        public List<Shop> Search(Shop start, Shop goal)
        {
            _visited = new HashSet<Shop>();
            _path = new List<Shop>();
            _goal = goal;
            Search(start);
            if (_path.Count > 0)
            {
                _path.Add(start);
            }
            return _path;
        }

        private bool Search(Shop shop)
        {
            if (shop == _goal)
            {
                return true;
            }
            _visited.Add(shop);
            foreach (var s in shop.LinkedShops.Where(x => !_visited.Contains(x)))
            {
                if (Search(s))
                {
                    _path.Add(s);
                    return true;
                }
            }
            return false;
        }
    }
}