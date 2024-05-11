using MFS.Shared.Dto.Authentication;
using MFS.Shared.Wrapper;

namespace MFS.Client.Infrastructure.Managers.Authentication;

public interface IAuthenticationManager : IManager
{
    Task<IResult<bool>> LoginAsync(LoginDto model);
}