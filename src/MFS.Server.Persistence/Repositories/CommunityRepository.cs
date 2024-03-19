using MFS.Core.Entities;
using MFS.Server.Infrastructure.Interfaces.Repositories;
using MFS.Server.Persistence.Contexts;

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
}