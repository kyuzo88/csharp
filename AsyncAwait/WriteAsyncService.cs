namespace AsyncAwait;

public static class WriteAsyncService
{
    public static async Task WriteAsync(int callOrder , int seconds)
    {
        await Task.Delay(seconds *1000);
        Console.WriteLine($"run {callOrder}: {seconds} seconds waited");
    }
}