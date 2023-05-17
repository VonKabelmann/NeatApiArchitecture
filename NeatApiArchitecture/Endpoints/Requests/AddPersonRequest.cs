using NeatApiArchitecture.DomainCommons.Enteties;

namespace NeatApiArchitecture.Presentation.Endpoints.Requests;

public class AddPersonRequest : IHttpRequest
{
    public Person Person { get; set; }
}