using System;
using System.Collections;
using ObserverAndIterator.Bank;
using ObserverAndIterator.DetectingSystem;
using ObserverAndIterator.Services;

namespace ObserverAndIterator
{
    public static class ObserverAndIteratorExecutor
    {
        public static void Execute()
        {
            IEnumerable bank = new BankCollection();
            var bankManager = new BankManager();
            
            bankManager.IntruderDetected += Detector.Warning;
            
            bankManager.PrintAllCustomersBalance(bank);
        }
    }
}