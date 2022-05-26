namespace WebAPI.Services;

public interface IWaitService
{
    public Task Wait();
}

public class WaitService : IWaitService
{
    public async Task Wait()
    {
        await Task.Delay(5 *1000);
    }
}