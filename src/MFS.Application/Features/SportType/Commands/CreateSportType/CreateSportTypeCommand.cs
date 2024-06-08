using MediatR;
using MFS.Shared.Wrapper;

namespace MFS.Application.Features.SportType.Commands.CreateSportType;

public class CreateSportTypeCommand : IRequest<Result<Guid>>
{
    public string Name { get; set; }
    public string Description { get; set; }
}