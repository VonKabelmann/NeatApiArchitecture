namespace NeatApiArchitecture.Presentation.Endpoints.Requests;

public class GetPersonByIdRequest : IHttpRequest
{
	public int Id { get; set; }
}