using System;
using AbstractFactoryAndBuilder.Abstractions;
using AbstractFactoryAndBuilder.Models;

namespace AbstractFactoryAndBuilder.Builders
{
    public class PcConfigure : IPeripheralsConfigure
    {
        private readonly Peripherals _peripherals = new Peripherals();

        public PcConfigure()
        {
            Console.WriteLine("\nPC configure\n");
        }
        
        public void PlugInSoundDevice()
        {
            _peripherals.Add(new SpeakerSystem());
        }

        public void PlugInKeyboard()
        {
            _peripherals.Add(new UsbKeyboard());
        }

        public void PlugInMouse()
        {
            _peripherals.Add(new UsbMouse());
        }

        public Peripherals GetPeripherals()
        {
            return _peripherals;
        }
    }
}