using System.Collections;

namespace BFS_DFS_Iterator.Iterator
{
    public class ShopIterator : IEnumerator
    {
        private readonly ShopCollection _shop;
        private int _position = -1;

        public ShopIterator(ShopCollection collection)
        {
            _shop = collection;
        }
        
        public bool MoveNext()
        {
            if(_position < _shop.Count - 1)
            {
                _position++;
                return true;
            }
            return false;

        }

        public void Reset()
        {
            _position = -1;
        }

        public object Current => _shop[_position];
    }
}