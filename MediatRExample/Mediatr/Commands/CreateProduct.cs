using MediatR;

namespace MediatRExample.Mediatr.Commands
{
    public static class CreateProduct
    {
        //Command
        public record Command : IRequest<Response>
        {
            public string Name { get; set; } = string.Empty;
            public string Description { get; set; } = string.Empty;
            public decimal Price { get; set; }
        }

        //Handler
        public class Handler : IRequestHandler<Command, Response>
        {
            public async Task<Response> Handle(Command request, CancellationToken cancellationToken)
            {

                var response = new Response
                {
                    Id = Helpers.GetRandomNumber(1, 10),
                    Name = request.Name,
                    Description = request.Description,
                    Price = request.Price,
                };

                return response;
            }
        }

        //Response
        public record Response() : Command
        {
            public int Id { get; init; }
        }

    }
}
