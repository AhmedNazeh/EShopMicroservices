

namespace Catalog.Api.Features.Products.CreateProduct
{
    public record CreateProductCommand(string Name, string Description, decimal Price, List<string> Category, string ImageFile)
        : ICommand<CreateProductResult>;
    public record CreateProductResult(Guid Id);
    public class CreateProductCommandHandler (IDocumentSession session): ICommandHandler<CreateProductCommand, CreateProductResult>
    {
        public async Task<CreateProductResult> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {

            var product = request.Adapt<Product>();
           

            // Logic to create a product

            session.Store(product);
           await  session.SaveChangesAsync(cancellationToken);

            var productId =product.Id; // Simulate product creation
            return new CreateProductResult(productId);
        }
    }
    
}
