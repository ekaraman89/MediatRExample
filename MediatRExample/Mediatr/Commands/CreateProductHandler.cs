using MediatR;

namespace MediatRExample.Mediatr.Commands
{
    public class CreateProductCommand : IRequest<int>
    {
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public decimal Price { get; set; }
    }
    public class CreateProductHandler : IRequestHandler<CreateProductCommand, int>
    {
        public Task<int> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            ///
            /// process...
            /// 

            Random random = new Random();
            return Task.FromResult(random.Next());
        }
    }
}
