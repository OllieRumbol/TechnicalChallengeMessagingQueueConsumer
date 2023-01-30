using Newtonsoft.Json;
using TechnicalChallengeMessagingQueueConsumerService.products;
using TechnicalChallengeMessagingQueueConsumerService.models;
using TechnicalChallengeMessagingQueueConsumerService.queue;

QueueProcessor queueProcessor = new QueueProcessor("localhost", "products");
IProductService productsService = new ProductService();

while (true)
{
    String message = queueProcessor.ReadMessageFromQueue();

    if (String.IsNullOrEmpty(message))
    {
        Console.WriteLine("No message in queue");
        Thread.Sleep(1000);
        continue;
    }

    Console.WriteLine($"Recived message: {message}");
    Product product = JsonConvert.DeserializeObject<Product>(message);
    Console.WriteLine(product.ToString());

    productsService.AddProduct(product);
}