using NeatApiArchitecture.DomainCommons.DataTransferObjects;
using NeatApiArchitecture.DomainCommons.Enteties;
using NeatApiArchitecture.DomainCommons.Interfaces;
using NeatApiArchitecture.Presentation.Endpoints.Requests;

namespace NeatApiArchitecture.Presentation.Extensions;

public static class EndpointExtensions
{
    public static WebApplication AddEndpoints(this WebApplication app)
    {
        app.MediateGet<GetAllPeopleRequest>("/people");

        app.MediateGet<GetPersonByIdRequest>("/people/{id}");

        app.MediatePost<AddPersonRequest>("/people");

        return app;
    }

    private static async Task<IEnumerable<Person>> GetAllPeople(IRepository<Person> repo)
    {
        return await repo.GetAllAsync();
    }
}