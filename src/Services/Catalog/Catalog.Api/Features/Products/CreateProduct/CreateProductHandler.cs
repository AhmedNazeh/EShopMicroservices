using MediatR;

namespace Catalog.Api.Features.Products.CreateProduct
{
    public record CreateProductCommand(string Name, string Description, decimal Price, string Category, string ImageUrl)
        : IRequest<CreateProductResult>;
    public record CreateProductResult(Guid Id);
    public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, CreateProductResult>
    {
        public Task<CreateProductResult> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            // Logic to create a product
            var productId = Guid.NewGuid(); // Simulate product creation
            return Task.FromResult(new CreateProductResult(productId));
        }
    }
    
}
