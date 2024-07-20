namespace FactoryMethod.DependencyInjection
{
    public interface ITransportFactoryBuilder
    {
        IServiceCollection Services { get; }
    }
}
