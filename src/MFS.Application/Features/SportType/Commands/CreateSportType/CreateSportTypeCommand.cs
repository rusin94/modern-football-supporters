using MediatR;
using MFS.Shared.Wrapper;

namespace MFS.Application.Features.SportType.Commands.CreateSportType;

public class CreateSportTypeCommand : IRequest<Result<int>>
{
}