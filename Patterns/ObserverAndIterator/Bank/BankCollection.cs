using System.Collections;
using System.Collections.Generic;
using Patterns.ObserverAndIterator.Models;

namespace ObserverAndIterator.Bank
{
    public class BankCollection : IEnumerable
    {
        private List<Customer> customers = new List<Customer>()
        {
            new Customer()
            {
                Name = "Petrov",
                Balance = 1000
            },
            new Customer()
            {
                Name = "Ivanov",
                Balance = 2000
            }
        };
            
        public IEnumerator GetEnumerator()
        {
            return new BankIterator(this);
        }

        public int Count => customers.Count;

        public Customer this[int index]
        {
            get => customers[index];
            set => customers.Insert(index, value);
        }
    }
}