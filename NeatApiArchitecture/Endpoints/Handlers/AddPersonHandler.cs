using System;
using System.Runtime.CompilerServices;
using MediatR;
using NeatApiArchitecture.BusinessLogic.Services;
using NeatApiArchitecture.DomainCommons.Enteties;
using NeatApiArchitecture.DomainCommons.Interfaces;
using NeatApiArchitecture.Presentation.Endpoints.Requests;

namespace NeatApiArchitecture.Presentation.Endpoints.Handlers;

public class AddPersonHandler : IRequestHandler<AddPersonRequest, IResult>
{
    private readonly IRepository<Person> _repo;

    public AddPersonHandler(IRepository<Person> repo)
    {
        _repo = repo;
    }

    public async Task<IResult> Handle(AddPersonRequest request, CancellationToken cancellationToken)
    {
        await _repo.AddAsync(request.Person);
        return Results.Ok();
    }
}