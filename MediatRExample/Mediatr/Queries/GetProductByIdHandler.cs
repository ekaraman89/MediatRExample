using MediatR;

namespace MediatRExample.Mediatr.Queries
{
    public class GetProductByIdDTO
    {
        public string Name { get; set; } = string.Empty;
        public decimal Price { get; set; }
    }
    public class GetProductByIdQuery : IRequest<GetProductByIdDTO>
    {
        public int Id { get; set; }

        public class GetProductByIdHandler : IRequestHandler<GetProductByIdQuery, GetProductByIdDTO>
        {
            public async Task<GetProductByIdDTO> Handle(GetProductByIdQuery request, CancellationToken cancellationToken)
            {
                ///
                /// process...
                /// 

                var model = new GetProductByIdDTO
                {
                    Name = "test",
                    Price = request.Id
                };
                return model;
            }
        }
    }
}
