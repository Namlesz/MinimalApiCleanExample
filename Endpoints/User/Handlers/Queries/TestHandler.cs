using Endpoints.User.Requests.Queries;
using MediatR;

namespace Endpoints.User.Handlers.Queries;

internal sealed class TestHandler : IRequestHandler<TestQuery, string>
{
    public Task<string> Handle(TestQuery request, CancellationToken cancellationToken) =>
        Task.FromResult("It's alive!");
}