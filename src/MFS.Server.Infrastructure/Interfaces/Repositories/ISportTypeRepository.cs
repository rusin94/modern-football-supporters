using MFS.Core.Entities;

namespace MFS.Server.Infrastructure.Interfaces.Repositories;

public interface ISportTypeRepository
{
    Task<List<SportType>> GetAllAsync();
    Task<SportType?> GetByIdAsync(int sportTypeId);
    SportType Create(SportType sportType);
    SportType Update(SportType sportType);
    void Delete(SportType sportType);
}