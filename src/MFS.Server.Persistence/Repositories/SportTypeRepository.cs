using MFS.Core.Entities;
using MFS.Server.Infrastructure.Interfaces.Repositories;
using MFS.Server.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;

namespace MFS.Server.Persistence.Repositories;

public class SportTypeRepository : ISportTypeRepository
{
    private readonly AppDbContext _context;
    
    public SportTypeRepository(AppDbContext context)
    {
        _context = context;
    }

    public Task<List<SportType>> GetAllAsync()
    {
        return _context.SportTypes.ToListAsync();
    }

    public Task<SportType?> GetByIdAsync(Guid sportTypeId)
    {
        return _context.SportTypes.FirstOrDefaultAsync(x => x.Id == sportTypeId);
    }

    public SportType Create(SportType sportType)
    {
        return _context.SportTypes.Add(sportType).Entity;
    }

    public SportType Update(SportType sportType)
    {
        return _context.SportTypes.Update(sportType).Entity;
    }

    public void Delete(SportType sportType)
    {
        _context.SportTypes.Remove(sportType);
    }
}