using AbstractFactoryAndBuilder.Abstractions;

namespace AbstractFactoryAndBuilder.Builders
{
    public class PeripheralsForeman
    {
        private  IPeripheralsConfigure PeripheralsConfigure { get; }
        
        public PeripheralsForeman(IPeripheralsConfigure peripheralsConfigure)
        {
            PeripheralsConfigure = peripheralsConfigure;
        }

        public void Assembly()
        {
            PeripheralsConfigure.PlugInSoundDevice();
            PeripheralsConfigure.PlugInKeyboard();
            PeripheralsConfigure.PlugInMouse();
        }
    }
}