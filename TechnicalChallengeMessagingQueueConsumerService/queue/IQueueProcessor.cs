namespace TechnicalChallengeMessagingQueueConsumerService.queue
{
    internal interface IQueueProcessor
    {
        string ReadMessageFromQueue();
    }
}
