using MFS.Core.Entities;

namespace MFS.Server.Infrastructure.Interfaces.Repositories;

public interface ICommunityRepository
{
    Community Create(Community community);
    Community Update(Community community);
    void Delete(Community community);

}