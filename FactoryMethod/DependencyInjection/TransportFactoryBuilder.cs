namespace FactoryMethod.DependencyInjection
{
    public class TransportFactoryBuilder : ITransportFactoryBuilder
    {
        public TransportFactoryBuilder(IServiceCollection services)
        {
            Services = services;
        }

        public IServiceCollection Services { get; }
    }
}
