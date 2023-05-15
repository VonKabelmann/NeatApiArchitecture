using MediatR;
using NeatApiArchitecture.DomainCommons.Enteties;
using NeatApiArchitecture.DomainCommons.Interfaces;
using NeatApiArchitecture.Presentation.Endpoints.Requests;

namespace NeatApiArchitecture.Presentation.Endpoints.Handlers;

public class GetAllPeopleHandler : IRequestHandler<GetAllPeopleRequest, IResult>
{
    private readonly IRepository<Person> _repo;

    public GetAllPeopleHandler(IRepository<Person> repo)
    {
        _repo = repo;
    }

    public async Task<IResult> Handle(GetAllPeopleRequest request, CancellationToken cancellationToken)
    {
        return Results.Ok(await _repo.GetAllAsync());
    }
}