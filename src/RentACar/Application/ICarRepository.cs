using Core.Persistence.Repositories;
using Domain.Entities;

namespace Application;

public interface ICarRepository : IAsyncRepository<Car, Guid>, IRepository<Car, Guid>
{
}