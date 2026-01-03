using Core.Persistence.Repositories;
using Domain.Entities;

namespace Application;

public interface IFuelRepository : IAsyncRepository<Fuel, Guid>, IRepository<Fuel, Guid>
{
}