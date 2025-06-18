using BuildingBlocks.CQRS;
using Catalog.Api.Models;

namespace Catalog.Api.Features.Products.CreateProduct
{
    public record CreateProductCommand(string Name, string Description, decimal Price, List<string> Category, string ImageFile)
        : ICommand<CreateProductResult>;
    public record CreateProductResult(Guid Id);
    public class CreateProductCommandHandler : ICommandHandler<CreateProductCommand, CreateProductResult>
    {
        public Task<CreateProductResult> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {

            var product = request.Adapt<Product>();
           

            // Logic to create a product
            var productId = Guid.NewGuid(); // Simulate product creation
            return Task.FromResult(new CreateProductResult(productId));
        }
    }
    
}
