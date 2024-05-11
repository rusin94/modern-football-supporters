using MFS.Shared.Dto.Authentication;
using MFS.Shared.Wrapper;

namespace MFS.Client.Infrastructure.Managers.Authentication;

public class AuthenticationManager : IAuthenticationManager
{
    public Task<IResult<bool>> LoginAsync(LoginDto model)
    {
        throw new NotImplementedException();
    }
}