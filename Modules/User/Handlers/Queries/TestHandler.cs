using MediatR;
using User.Requests.Queries;

namespace User.Handlers.Queries;

internal sealed class TestHandler : IRequestHandler<TestQuery, string>
{
    public Task<string> Handle(TestQuery request, CancellationToken cancellationToken)
    {
        return Task.FromResult("It's alive!");
    }
}