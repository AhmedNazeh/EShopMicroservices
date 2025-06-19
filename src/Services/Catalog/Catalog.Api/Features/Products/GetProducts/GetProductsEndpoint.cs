
namespace Catalog.Api.Features.Products.GetProducts
{
    public class GetProductsEndpoint : ICarterModule
    {
        public void AddRoutes(IEndpointRouteBuilder app)
        {
            app.MapGet("/products", async (ISender sender) =>
            {
                var query = new GetProductsQuery();
                var products = await sender.Send(query);
                return Results.Ok(products);
            });
        }
    }
}
