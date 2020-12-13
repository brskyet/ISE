namespace AbstractFactoryAndBuilder.Abstractions
{
    public interface IConfigureCreator
    {
        IPeripheralsConfigure CreateConfiguration();
    }
}