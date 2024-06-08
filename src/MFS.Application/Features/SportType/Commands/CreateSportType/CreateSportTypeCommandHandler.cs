using MediatR;
using MFS.Server.Infrastructure.Interfaces.Repositories;
using MFS.Shared.Wrapper;

namespace MFS.Application.Features.SportType.Commands.CreateSportType;

public class CreateSportTypeCommandHandler : IRequestHandler<CreateSportTypeCommand, Result<Guid>>
{

    private readonly ISportTypeRepository _sportTypeRepository;
    private readonly IUnitOfWork _unitOfWork;


    public CreateSportTypeCommandHandler(ISportTypeRepository sportTypeRepository, IUnitOfWork unitOfWork)
    {
        _sportTypeRepository = sportTypeRepository;
        _unitOfWork = unitOfWork;
    }
    public async Task<Result<Guid>> Handle(CreateSportTypeCommand request, CancellationToken cancellationToken)
    {
        var sportType = new Core.Entities.SportType
        {
            Name = request.Name,
            Description = request.Description
        };
        _sportTypeRepository.Create(sportType);
        await _unitOfWork.SaveChangesAsync(cancellationToken);
        return await Result<Guid>.SuccessAsync(sportType.Id, "Sport Type Created");
    }
}