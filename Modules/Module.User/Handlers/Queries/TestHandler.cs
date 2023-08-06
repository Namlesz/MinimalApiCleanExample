using MediatR;
using Module.User.Requests.Queries;

namespace Module.User.Handlers.Queries;

internal sealed class TestHandler : IRequestHandler<TestQuery, string>
{
    public Task<string> Handle(TestQuery request, CancellationToken cancellationToken)
        => Task.FromResult("It's alive!");
}