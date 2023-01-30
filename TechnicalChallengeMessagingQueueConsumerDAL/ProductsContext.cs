using TechnicalChallengeMessagingQueueConsumerService.models;

namespace TechnicalChallengeMessagingQueueConsumerDAL;

// Mocked DB service as part of the challenge.
// In real life I would use entity framework (model first) to map a realtion datbase in c#
public class ProductsContext
{
    public static List<Product> products = new List<Product>();

    public void Add(Product product)
    {
        products.Add(product);
    }
}