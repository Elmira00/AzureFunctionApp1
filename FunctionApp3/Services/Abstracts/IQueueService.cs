namespace FunctionApp1.Services.Abstracts
{
    public interface IQueueService
    {
        Task SendMessageAsync(string message);
        Task<string> ReceiveMessageAsync();
    }
}
