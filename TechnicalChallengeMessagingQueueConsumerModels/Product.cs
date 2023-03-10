namespace TechnicalChallengeMessagingQueueConsumerService.models;

public class Product
{
    public int Id { get; set; }

    public string Title { get; set; }

    public double Price { get; set; }

    public override string ToString()
    {
        return $"Id: {Id}, Title: {Title}, Price: {Price}";
    }
}
