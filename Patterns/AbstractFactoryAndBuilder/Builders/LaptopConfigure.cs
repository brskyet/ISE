using System;
using AbstractFactoryAndBuilder.Abstractions;
using AbstractFactoryAndBuilder.Models;

namespace AbstractFactoryAndBuilder.Builders
{
    public class LaptopConfigure : IPeripheralsConfigure
    {
        private readonly Peripherals _peripherals = new Peripherals();

        public LaptopConfigure()
        {
            Console.WriteLine("\nLaptop configure.\n");
        }
        
        public void PlugInSoundDevice()
        {
            _peripherals.Add(new Headphones());
        }

        public void PlugInKeyboard()
        {
            _peripherals.Add(new BluetoothKeyboard());
        }

        public void PlugInMouse()
        {
            _peripherals.Add(new BluetoothMouse());
        }

        public Peripherals GetPeripherals()
        {
            return _peripherals;
        }
    }
}