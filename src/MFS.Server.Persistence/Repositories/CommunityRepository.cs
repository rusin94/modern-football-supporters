using MFS.Core.Entities;
using MFS.Server.Infrastructure.Interfaces.Repositories;
using MFS.Server.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;

namespace MFS.Server.Persistence.Repositories;

public class CommunityRepository:ICommunityRepository
{
    private readonly AppDbContext _appDbContext;

    public CommunityRepository(AppDbContext appDbContext)
    {
        _appDbContext = appDbContext;
    }

    public Community Create(Community community)
    {
        return _appDbContext.Communities.Add(community).Entity;
    }

    public Community Update(Community community)
    {
        return _appDbContext.Communities.Update(community).Entity;
    }

    public void Delete(Community community)
    {
        _appDbContext.Communities.Remove(community);
    }

    public async Task<Community> GetByIdAsync(int communityId)
    {
        return await _appDbContext.Communities.FindAsync(communityId);
    }

    public async Task<List<Community>> GetAllAsync()
    {
        return await _appDbContext.Communities.ToListAsync();
    }
}