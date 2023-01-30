using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnicalChallengeMessagingQueueConsumerService.queue
{
    internal interface IQueueProcessor
    {
        string ReadMessageFromQueue();
    }
}
