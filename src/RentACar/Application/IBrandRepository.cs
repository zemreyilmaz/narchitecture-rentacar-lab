using Core.Persistence.Repositories;
using Domain.Entities;

namespace Application;

public interface IBrandRepository : IAsyncRepository<Brand, Guid>, IRepository<Brand, Guid>
{
}