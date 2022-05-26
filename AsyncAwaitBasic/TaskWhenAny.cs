namespace AsyncAwaitBasic;

public class TaskWhenAny
{
    public static async Task RunAsync(List<Task> tasks)
    {
        while (tasks.Count > 0)
        {
            var finishedTask = await Task.WhenAny(tasks);
            tasks.Remove(finishedTask);
        }
    }
}