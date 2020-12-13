using System.Collections;
using System.Collections.Generic;
using BFS_DFS_Iterator.Services;

namespace BFS_DFS_Iterator.Iterator
{
    public class ShopCollection : IEnumerable
    {
        private readonly List<Shop> _shops = new List<Shop>()
        {
            new Shop("01"),
            new Shop("02"),
            new Shop("03"),
            new Shop("04"),
            new Shop("05"),
            new Shop("06"),
            new Shop("07"),
            new Shop("08"),
            new Shop("09"),
            new Shop("10"),
            new Shop("11"),
            new Shop("12"),
            new Shop("13"),
            new Shop("14"),
            new Shop("15")
        };

        public ShopCollection()
        {
            _shops[0].AddRoute(_shops[1]).AddRoute(_shops[2]);
            _shops[1].AddRoute(_shops[4]);
            _shops[2].AddRoute(_shops[3]);
            _shops[3].AddRoute(_shops[4],false).AddRoute(_shops[9],false).AddRoute(_shops[10],false);
            _shops[5].AddRoute(_shops[0],false);
            _shops[6].AddRoute(_shops[2],false).AddRoute(_shops[7]);
            _shops[8].AddRoute(_shops[7]).AddRoute(_shops[9]);
            _shops[10].AddRoute(_shops[11]).AddRoute(_shops[12]);
            _shops[11].AddRoute(_shops[12]);
            _shops[13].AddRoute(_shops[14]);
        }
            
        public IEnumerator GetEnumerator()
        {
            return new ShopIterator(this);
        }

        public int Count => _shops.Count;

        public Shop this[int index]
        {
            get => _shops[index];
            set => _shops.Insert(index, value);
        }
    }
}