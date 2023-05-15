using MediatR;
using NeatApiArchitecture.Presentation.Endpoints.Requests;

namespace NeatApiArchitecture.Presentation.Extensions;

public static class MediatREndpointExtensions
{
    public static WebApplication MediateGet<TRequest>(
        this WebApplication app,
        string path) 
        where TRequest : IHttpRequest
    {
        app.MapGet(path, async (IMediator mediator, [AsParameters] TRequest request) => await mediator.Send(request));
        return app;
    } 
}