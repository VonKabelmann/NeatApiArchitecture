using MediatR;
using NeatApiArchitecture.DomainCommons.Enteties;
using NeatApiArchitecture.DomainCommons.Interfaces;
using NeatApiArchitecture.Presentation.Endpoints.Requests;

namespace NeatApiArchitecture.Presentation.Endpoints.Handlers;

public class GetByIdHandler : IRequestHandler<GetPersonByIdRequest, IResult>
{
	private readonly IRepository<Person> _repo;

	public GetByIdHandler(IRepository<Person> repo)
	{
		_repo = repo;
	}

	public async Task<IResult> Handle(GetPersonByIdRequest request, CancellationToken cancellationToken)
	{
		return Results.Ok(await _repo.GetByIdAsync(request.Id));
	}
}