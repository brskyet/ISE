using AbstractFactoryAndBuilder.Abstractions;
using AbstractFactoryAndBuilder.Builders;

namespace AbstractFactoryAndBuilder.Factories
{
    public class LaptopConfigurationCreator : IConfigureCreator
    {
        public IPeripheralsConfigure CreateConfiguration()
        {
            return new LaptopConfigure();
        }
    }
}