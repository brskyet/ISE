using System.Collections;

namespace ObserverAndIterator.Bank
{
    public class BankIterator : IEnumerator
    {
        private BankCollection bank;
        private int position = -1;

        public BankIterator(BankCollection collection)
        {
            bank = collection;
        }
        
        public bool MoveNext()
        {
            if(position < bank.Count - 1)
            {
                position++;
                return true;
            }
            return false;

        }

        public void Reset()
        {
            position = -1;
        }

        public object Current => bank[position];
    }
}