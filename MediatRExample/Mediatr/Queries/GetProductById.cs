using MediatR;

namespace MediatRExample.Mediatr.Queries
{
    public static class GetProductById
    {
        // Query / Command
        public record Query(int Id) : IRequest<Response>;

        //handler
        public class Handler : IRequestHandler<Query, Response>
        {
            public async Task<Response> Handle(Query request, CancellationToken cancellationToken)
            {
                var model = new Response(Helpers.GetRandomText(), Helpers.GetRandomNumber(1, 10));
                return model;
            }
        }

        //response
        public record Response(string Name, decimal Price);

    }
}
