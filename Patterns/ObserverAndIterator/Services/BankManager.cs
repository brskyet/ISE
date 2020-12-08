using System;
using System.Collections;
using ObserverAndIterator.Models;

namespace ObserverAndIterator.Services
{
    public class BankManager
    {
        public event EventHandler<string> IntruderDetected;
        
        public void PrintAllCustomersBallance(IEnumerable collection)
        {
            var enumerator = collection.GetEnumerator();

            while (enumerator.MoveNext())
            {
                var customer = enumerator.Current as Customer;
                Console.WriteLine($"Name: {customer?.Name},\tBalance: {customer?.Balance}");
                IntruderDetected?.Invoke(this, customer?.Name);
            }
        }
    }
}