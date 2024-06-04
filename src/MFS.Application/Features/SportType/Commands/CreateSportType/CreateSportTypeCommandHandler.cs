using MediatR;
using MFS.Shared.Wrapper;

namespace MFS.Application.Features.SportType.Commands.CreateSportType;

public class CreateSportTypeCommandHandler : IRequestHandler<CreateSportTypeCommand, Result<int>>
{
}