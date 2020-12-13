using AbstractFactoryAndBuilder.Abstractions;
using AbstractFactoryAndBuilder.Builders;

namespace AbstractFactoryAndBuilder.Factories
{
    public class PcConfigurationCreator : IConfigureCreator
    {
        public IPeripheralsConfigure CreateConfiguration()
        {
            return new PcConfigure();
        }
    }
}