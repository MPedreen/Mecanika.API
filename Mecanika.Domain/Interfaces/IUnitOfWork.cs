using Mecanika.Domain.Interfaces.Repositories;

namespace Mecanika.Domain.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IClientRepository Clients { get; }
        IEmployeeRepository Employees { get; }
        IEstablishmentRepository Establishments { get; }
        IProductRepository Products { get; }
        IQueueRepository Queues { get; }
        ISchedulingRepository Schedulings { get; }
        IServiceRepository Services { get; }
        IStockRepository Stocks { get; }
        ISupplierRepository Suppliers { get; }
        IVehicleRepository Vehicles { get; }
        int Complete();
    }
}
