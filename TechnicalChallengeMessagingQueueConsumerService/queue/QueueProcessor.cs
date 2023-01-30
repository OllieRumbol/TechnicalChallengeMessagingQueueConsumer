using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System.Text;

namespace TechnicalChallengeMessagingQueueConsumerService.queue;

public class QueueProcessor : IQueueProcessor
{
    private string HostName;
    private string QueueName;

    public QueueProcessor(string hostName, string queueName)
    {
        HostName = hostName;
        QueueName = queueName;
    }

    public string ReadMessageFromQueue()
    {
        //string messageFromQueue = string.Empty;

        ConnectionFactory factory = new ConnectionFactory
        {
            HostName = HostName
        };

        using (IConnection connection = factory.CreateConnection())
        using (IModel channel = connection.CreateModel())
        {
            channel.QueueDeclare(queue: QueueName,
                              durable: false,
                              exclusive: false,
                              autoDelete: false,
                              arguments: null);

            var consumer = new EventingBasicConsumer(channel);
            consumer.Received += (model, eventArgs) =>
            {
                var body = eventArgs.Body.ToArray();
                var message = Encoding.UTF8.GetString(body);
            };

            BasicGetResult data = channel.BasicGet(QueueName, true);
            if (data is null)
            {
                return string.Empty;
            }

            return Encoding.UTF8.GetString(data.Body.ToArray());
        }
    }
}
