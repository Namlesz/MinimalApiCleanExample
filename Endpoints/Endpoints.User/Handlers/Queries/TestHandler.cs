using Endpoints.User.Requests.Queries;
using MediatR;

namespace Endpoints.User.Handlers.Queries;

public class TestHandler : IRequestHandler<TestQuery, string>
{
    public Task<string> Handle(TestQuery request, CancellationToken cancellationToken)
    {
        return Task.FromResult("It's alive!");
    }
}