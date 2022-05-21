namespace AsyncAwait;

public static  class TaskWhenAll
{
    public static async Task RunAsync(List<Task> tasks)
    {
        await Task.WhenAll(tasks);
    }
}