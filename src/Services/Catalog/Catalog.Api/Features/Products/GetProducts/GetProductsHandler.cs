using Marten.Linq.QueryHandlers;

namespace Catalog.Api.Features.Products.GetProducts
{
    public record GetProductsQuery() : IQuery<IEnumerable<Product>>;

    public class GetProductsQueryHandler(IDocumentSession session) : IQueryHandler<GetProductsQuery, IEnumerable<Product>>
    {
     
        public async Task<IEnumerable<Product>> Handle(GetProductsQuery request, CancellationToken cancellationToken)
        {
            var products = await session.Query<Product>().ToListAsync(cancellationToken);
            return products;
        }
    }
   
    
}
