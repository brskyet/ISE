using AbstractFactoryAndBuilder.Abstractions;
using AbstractFactoryAndBuilder.Builders;
using AbstractFactoryAndBuilder.Factories;

namespace AbstractFactoryAndBuilder
{
    public static class AbstractFactoryAndBuilderExecutor
    {
        public static void Execute()
        {
            var devicesCreators = new IConfigureCreator[2];
            devicesCreators[0] = new PcConfigurationCreator();
            devicesCreators[1] = new LaptopConfigurationCreator();
            foreach (var devicesCreator in devicesCreators)
            {
                var foreman = new PeripheralsForeman(devicesCreator.CreateConfiguration());
                foreman.Assembly();
            }
        }
    }
}