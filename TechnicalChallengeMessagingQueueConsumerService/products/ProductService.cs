using TechnicalChallengeMessagingQueueConsumerDAL;
using TechnicalChallengeMessagingQueueConsumerService.models;

namespace TechnicalChallengeMessagingQueueConsumerService.products;

public class ProductService : IProductService
{
    private readonly ProductsContext _ProductsContext;

    public ProductService(ProductsContext _productsContext)
    {
        _ProductsContext= _productsContext;
    }

    public ProductService()
    {
        _ProductsContext = new ProductsContext();
    }

    public Product AddProduct(Product product)
    {
        _ProductsContext.Add(product);

        return product;
    }
}
