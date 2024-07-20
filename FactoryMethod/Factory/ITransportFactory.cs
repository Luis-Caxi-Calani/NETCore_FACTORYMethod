using FactoryMethod.Enums;
using FactoryMethod.Transports;

namespace FactoryMethod.Factory
{
    public interface ITransportFactory
    {
        void RegisterTransport(TransportType transportType,
            Func<ITransport> factoryMethod);

        ITransport CreateTransport(TransportType transportType);
    }
}
