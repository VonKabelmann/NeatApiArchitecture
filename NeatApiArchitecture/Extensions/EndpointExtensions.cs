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
        app.MapPost("/people", async (IRepository<Person> repo, Person person) =>
        {
            await repo.AddAsync(person);
            return person;
        }).WithOpenApi();

        return app;
    }

    private static async Task<IEnumerable<Person>> GetAllPeople(IRepository<Person> repo)
    {
        return await repo.GetAllAsync();
    }
}