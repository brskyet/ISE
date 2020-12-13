using AbstractFactoryAndBuilder.Builders;

namespace AbstractFactoryAndBuilder.Abstractions
{
    public interface IPeripheralsConfigure
    {
        void PlugInSoundDevice();

        void PlugInKeyboard();

        void PlugInMouse();

        Peripherals GetPeripherals();
    }
}