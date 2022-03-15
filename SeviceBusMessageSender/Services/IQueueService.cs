using System.Threading.Tasks;

namespace SeviceBusMessageSender.Services
{
    public interface IQueueService
    {
        Task SendMessageAsync<T>(T serviceBusMessage, string queueName);
    }
}